using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.UserViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service
{
    public interface IUserService
    {
        Task<User> RegisterAsync(UserRegisterRequest userRegisterRequest);
        Task<IEnumerable<UserRequest>> GetAllAsync();
        Task<User> UpdateAsync(UserUpdateRequest userUpdateRequest);
        Task<bool> DeleteAsync(int id);
        Task<UserRequest> GetByIdAsync(int id);
        string Authenticate(UserLoginRequest userLogin);
    }
}
