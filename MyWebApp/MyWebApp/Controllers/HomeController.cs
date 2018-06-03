﻿using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _repository;
        public HomeController(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var t = _repository.ListarProdutos();
            return View(_repository.ListarProdutos());
        }

        public string Obter()
        {
            return "teste2";
        }
    }
}
