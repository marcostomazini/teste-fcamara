﻿
using Angle_MVC6_Angular_Seed.Models.AgendaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angle_MVC6_Angular_Seed.Models.Repositorio
{
    public interface IProdutoRepositorio
    {
        /// <summary>
        ///     Retorna uma lista dos produtos
        /// </summary>
        /// <returns></returns>
        IEnumerable<Produto> Produtos();
    }
}
