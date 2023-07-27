using OrderFlow.Api.Models;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Services.Interfaces
{
    public interface IUserService
    {
        public LoginResponseViewModel GetUserByCredentials(string userName, string password);
        public void CreateUser(User user);
        public void ChangePassword(User user);
    }
}
