using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicoWcf.Model.Interfaces
{
    public interface ITokenValidator
    {
        /// <summary>
        ///     Valida o token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        bool IsValid(string token);
    }
}