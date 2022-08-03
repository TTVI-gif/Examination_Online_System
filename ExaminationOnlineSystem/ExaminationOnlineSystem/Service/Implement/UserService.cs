using AutoMapper;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Exeption;
using ExaminationOnlineSystem.HashPBKDF2;
using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.UOF;
using ExaminationOnlineSystem.ViewModel.UserViewModel;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service.Implement
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _iconfiguration;
        public UserService(IMapper mapper, IUnitOfWork unitOfWork, IConfiguration iconfiguration)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _iconfiguration = iconfiguration;
        }

        public string Authenticate(UserLoginRequest userLogin)
        {
            var user = _unitOfWork.UserRepository.Authenticate(userLogin);
            if (user == null)
                throw new AppException("User is null");
            //check password incorrect
            var isPassword = Hash.Validate(userLogin.Password, user.Salt, user.Password);
            if (!isPassword)
                return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_iconfiguration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
                    new Claim(ClaimTypes.Name, userLogin.UserName),
                    new Claim(ClaimTypes.NameIdentifier, userLogin.UserName),
                    new Claim(ClaimTypes.Role, user.Role.ToString())

              }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(id);
            var result = _unitOfWork.UserRepository.Delete(user);
            if (result != null)
            {
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<UserRequest>> GetAllAsync()
        {
            var users = await _unitOfWork.UserRepository.GetAllAsync(x => new UserRequest(x));
            return users;
        }

        public async Task<UserRequest> GetByIdAsync(int id)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(id);
            return new UserRequest(user);
        }

        public async Task<User> RegisterAsync(UserRegisterRequest userRegisterRequest)
        {
            if (_unitOfWork.UserRepository.CheckDuliCateUser(userRegisterRequest))
                throw new AppException($"UserName {userRegisterRequest.UserName} đã tồn tại");
            if (_unitOfWork.UserRepository.CheckDuliCateEmail(userRegisterRequest))
                throw new AppException($"Email {userRegisterRequest.Email} đã tồn tại");
            var salt = Salt.Create();
            var user = _mapper.Map<User>(userRegisterRequest);
            user.Password = Hash.HashPassWord(userRegisterRequest.Password, salt);
            user.Salt = salt;
            await _unitOfWork.UserRepository.AddAsync(user);
            await _unitOfWork.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateAsync(UserUpdateRequest userUpdateRequest)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(userUpdateRequest.Id);
            user.FirstName = userUpdateRequest.FirstName;
            user.LastName = userUpdateRequest.LastName;
            user.PhoneNumber = userUpdateRequest.PhoneNumber;
            user.Email = userUpdateRequest.Email;
            user.BirthDay = userUpdateRequest.BirthDay;
            _unitOfWork.UserRepository.Update(user);
            await _unitOfWork.SaveChangesAsync();
            return user;
        }
    }
}
