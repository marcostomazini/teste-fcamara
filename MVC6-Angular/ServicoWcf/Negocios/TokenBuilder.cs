using ServicoWcf.Model;
using ServicoWcf.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Web;

namespace ServicoWcf.Negocios
{
    public class TokenBuilder : ITokenBuilder
    {
        internal static Dictionary<string, DateTime> tokens = new Dictionary<string, DateTime>();

        /// <summary>
        ///     Cria novo token
        /// </summary>
        /// <returns></returns>
        public string Build()
        {           
            var token = Guid.NewGuid().ToString();

            tokens.Add(token, DateTime.Now);            

            if (new CredentialsValidator().IsValid())
                return token;

            throw new AuthenticationException();
        }
    }
}