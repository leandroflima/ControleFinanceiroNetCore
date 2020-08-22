using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        public ActionResult<List<Produto>> Index()
        {
            return View(_produtoService.Get());
        }

        // GET: Produto/Details/5
        public ActionResult<Produto> Details(Guid id)
        {
            return View(_produtoService.Get(id));
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult<Produto> Create([Bind]Produto produto)
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
        public IActionResult Edit(Guid id, [Bind]Produto produtoIn)
        {
            try
            {
                var produto = _produtoService.Get(id);

                if (produto != null)
                {
                    _produtoService.Update(id, produtoIn);
                }

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
                var produto = _produtoService.Get(id);

                if (produto != null)
                {
                    _produtoService.Remove(produto.Id);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}