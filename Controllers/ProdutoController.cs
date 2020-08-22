using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ControleFinanceiroNetCore.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET: Produto
        public IActionResult Index()
        {
            return View(_produtoService.Get());
        }

        // GET: Produto/Details/5
        public IActionResult Details(Guid id)
        {
            return View(_produtoService.Get(id));
        }

        // POST: Produto/Create
        [HttpPost]
        public IActionResult Create([Bind]Produto produto)
        {
            try
            {
                _produtoService.Create(produto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public IActionResult Edit(Guid id, [Bind]Produto produto)
        {
            try
            {
                _produtoService.Update(id, produto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _produtoService.Remove(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}