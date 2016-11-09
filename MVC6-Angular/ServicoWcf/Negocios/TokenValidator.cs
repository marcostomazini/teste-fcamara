using ServicoWcf.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicoWcf.Negocios
{
    public class TokenValidator : ITokenValidator
    {
        public bool IsValid(string token)
        {
            new CredentialsValidator().RemoveExpirados();

            var isValid = TokenBuilder.tokens
                .Any(p => p.Key == token);

            return isValid;
        }
    }
}