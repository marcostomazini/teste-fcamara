using ServicoWcf.Model;
using ServicoWcf.Model.Interfaces;
using ServicoWcf.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace ServicoWcf
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AuthenticationTokenService
    {
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        public string GenerateToken()
        {
            ICredentialsValidator validator = new CredentialsValidator();
            if (validator.IsValid())
                return new TokenBuilder().Build();
            throw new InvalidCredentialException("Invalid credentials");
        }

        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
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
