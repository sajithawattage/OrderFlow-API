using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

public class JwtAuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        string authHeader = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
        IConfiguration configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

        if ((authHeader == null || !authHeader.StartsWith("Bearer ")) 
            || configuration == null)
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var tokenStr = authHeader.Substring("Bearer ".Length).Trim();

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(configuration["Jwt:Key"].ToString()); 

        try
        {
            tokenHandler.ValidateToken(tokenStr,
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);
        }
        catch
        {
            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
