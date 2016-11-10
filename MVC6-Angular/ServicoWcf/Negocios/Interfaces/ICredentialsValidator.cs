using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicoWcf.Model.Interfaces
{
    public interface ICredentialsValidator
    {
        /// <summary>
        ///     Remove tokens expirados
        /// </summary>
        void RemoveExpirados();

        /// <summary>
        ///     Valida se o token esta valido
        /// </summary>
        /// <returns></returns>
        bool IsValid();
    }
}