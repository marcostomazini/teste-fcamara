using Angle_MVC6_Angular_Seed.Data;
using Angle_MVC6_Angular_Seed.Models.AgendaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angle_MVC6_Angular_Seed.Models.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ApplicationDbContext _dbContext;

        public ProdutoRepositorio(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Produto> Produtos()
        {
            return _dbContext.Produtos.AsEnumerable();
        }
    }
}
