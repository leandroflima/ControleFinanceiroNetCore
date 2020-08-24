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
            var item = _produtoService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Produto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult<Produto> Create([Bind("Codigo,Descricao,Pontos")]Produto item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _produtoService.Create(item);

                    return RedirectToAction(nameof(Index));
                }
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
            var item = _produtoService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public IActionResult Edit(Guid id, [Bind("Id,Codigo,Descricao,Pontos")]Produto itemIn)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = _produtoService.Get(id);

                    if (item == null)
                    {
                        return NotFound();
                    }

                    _produtoService.Update(id, itemIn);

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(itemIn);
        }

        // GET: Produto/Delete/5
        public IActionResult Delete(Guid id)
        {
            var item = _produtoService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = _produtoService.Get(id);
                    if (item != null)
                    {
                        _produtoService.Remove(item.Id);
                    }

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }
    }
}