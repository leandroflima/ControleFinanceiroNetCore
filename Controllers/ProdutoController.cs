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
            var produto = _produtoService.Get(id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult<Produto> Create([Bind("Codigo,Descricao,Pontos")]Produto produto)
        {
            try
            {
                _produtoService.Create(produto);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }

        // GET: Produto/Edit/5
        public IActionResult Edit(Guid id)
        {
            var produto = _produtoService.Get(id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public IActionResult Edit(Guid id, [Bind("Id,Codigo,Descricao,Pontos")]Produto produtoIn)
        {
            try
            {
                var produto = _produtoService.Get(id);

                if (produto == null)
                {
                    return NotFound();
                }

                _produtoService.Update(id, produtoIn);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(produtoIn);
        }

        // GET: Produto/Delete/5
        public IActionResult Delete(Guid id)
        {
            var produto = _produtoService.Get(id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
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
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }
    }
}