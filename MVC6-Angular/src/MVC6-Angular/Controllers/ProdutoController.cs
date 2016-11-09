using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Angle_MVC6_Angular_Seed.Models.PessoaViewModels;
using Angle_MVC6_Angular_Seed.Models;
using Angle_MVC6_Angular_Seed.Models.Repositorio;
using System.Net.Http;
using System.Net;

namespace Angle_MVC6_Angular_Seed.Controllers
{
    public class ProdutoController : Controller
    {
        public readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        #region Index

        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult IndexFilter()
        {
            var x = HttpContext.Request.Headers["xCross"].FirstOrDefault();
            if (x.ToUpper() == bool.TrueString.ToUpper()) return Error();

            var agendas = _produtoRepositorio.Produtos();

            return Ok(agendas);
        }

        #endregion

        public IActionResult BuscaProduto()
        {
            var agendas = _produtoRepositorio.Produtos();

            return Ok(agendas);
        }           

        public IActionResult Error()
        {
            return View();
        }
    }
}
