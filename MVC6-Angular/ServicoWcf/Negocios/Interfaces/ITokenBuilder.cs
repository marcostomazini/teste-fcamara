using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicoWcf.Model.Interfaces
{
    interface ITokenBuilder
    {
        /// <summary>
        ///     Constroi o token
        /// </summary>
        /// <returns></returns>
        string Build();
    }
}