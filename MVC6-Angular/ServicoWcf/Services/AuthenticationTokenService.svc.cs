using ServicoWcf.Model.Interfaces;
using ServicoWcf.Negocios;
using ServicoWcf.Services.Interfaces;
using System.Security.Authentication;
using System.Web;

namespace ServicoWcf
{
    public class AuthenticationTokenService : IAuthenticationTokenService
    {
        public string GenerateToken()
        {
            ICredentialsValidator validator = new CredentialsValidator();
            if (validator.IsValid())
                return new TokenBuilder().Build();
            throw new InvalidCredentialException("Credencial inválida.");
        }

        public bool ValidateToken()
        {
            var token = HttpContext.Current.Request.Headers["Token"];
            ITokenValidator validator = new TokenValidator();
            if (validator.IsValid(token))
            {
                return true;
            }

            return false;
        }
    }
}
