using MD5Hash;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using OrderFlow.Api.Models;
using OrderFlow.Api.Services.Interfaces;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IConfiguration _configuration;
        private readonly SeefaErpceytramContext erpceytramContext;

        public UserService(IConfiguration configuration, SeefaErpceytramContext erpceytramContext)
        {
            _configuration = configuration;
            this.erpceytramContext = erpceytramContext;
        }

        public void AuthenticateUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(Models.User user)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(Models.User user)
        {
            throw new NotImplementedException();
        }

        public LoginResponseViewModel GetUserByCredentials(string userName, string password)
        {
            var user = erpceytramContext.Users.Where(x => x.UserName == userName
                                && x.Password == Hash.Content(password)).FirstOrDefault();
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            user.UserLevel = user.UserLevel ?? -1;
            user.RepCode = user.RepCode ?? -1;

            var tokenString = GenerateJSONWebToken(user.UserName, user.UserId, user.UserLevel.Value,
                user.RepCode.Value, user.AreaCode, user.Active.Value.ToString());

            return new LoginResponseViewModel
            {
                body = new Claims
                {
                    Active = user.Active.Value,
                    AreaCode = user.AreaCode,
                    RepCode = user.RepCode,
                    UserId = user.UserId,
                    UserLevel = user.UserLevel,
                    UserName = user.UserName
                },
                isError = false,
                message = string.Empty,
                token = tokenString
            };

        }

        private string GenerateJSONWebToken(string userName, int userId, int userLevel, int repCode,
                                                string areaCode, string active)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, userId.ToString()),
                new Claim("user_level", userLevel.ToString()),
                new Claim("rep_code", repCode.ToString()),
                new Claim("area_code", areaCode),
                new Claim("active", active)
            };

            var token = new JwtSecurityToken(issuer: null,
                audience: null,
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
