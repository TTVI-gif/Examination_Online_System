using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.UserViewModel;

namespace ExaminationOnlineSystem.Repository
{
    public interface IUserRepository : IDataRepository<User>
    {
        User Authenticate(UserLoginRequest loginRequest);
        bool CheckDuliCateUser(UserRegisterRequest userRegisterRequest);
        bool CheckDuliCateEmail(UserRegisterRequest userRegisterRequest);
    }
}
