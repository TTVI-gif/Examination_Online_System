using ExaminationOnlineSystem.EF;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Repository;
using ExaminationOnlineSystem.ViewModel.UserViewModel;
using System.Linq;

namespace ExaminationOnlineSystem.Repository.Implement
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {

        public UserRepository(IExamSystemDbContext context) : base(context)
        {

        }

        public User Authenticate(UserLoginRequest loginRequest)
        {
            if (string.IsNullOrEmpty(loginRequest.UserName) || string.IsNullOrEmpty(loginRequest.Password))
                return null;
            var user = DbSet.SingleOrDefault(x => x.UserName == loginRequest.UserName);
            // check if username exists
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public bool CheckDuliCateEmail(UserRegisterRequest userRegisterRequest)
        {
            var isEmail = DbSet.Any(x => x.Email == userRegisterRequest.Email);
            if (isEmail)
                return true;
            return false;
        }

        public bool CheckDuliCateUser(UserRegisterRequest userRegisterRequest)
        {
            var isUser = DbSet.Any(x => x.UserName == userRegisterRequest.UserName);
            if (isUser)
                return true;
            return false;
        }
    }
}
