using ServicoWcf.Model;
using ServicoWcf.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace ServicoWcf.Negocios
{
    public class CredentialsValidator : ICredentialsValidator
    {
        public void RemoveExpirados()
        {
            var remover = new List<string>();

            var expiredTokens = TokenBuilder.tokens
                .Where(p => p.Value.AddMinutes(1) <= DateTime.Now);

            foreach (var item in expiredTokens)
                remover.Add(item.Key);

            foreach (var item in remover)
                TokenBuilder.tokens.Remove(item);
        }

        public bool IsValid()
        {
            RemoveExpirados();        
            return true;
        }
    }
}