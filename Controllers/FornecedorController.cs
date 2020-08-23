using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        // GET: fornecedor
        public ActionResult<List<Fornecedor>> Index()
        {
            return View(_fornecedorService.Get());
        }

        // GET: fornecedor/Details/5
        public ActionResult<Fornecedor> Details(Guid id)
        {
            var item = _fornecedorService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: fornecedor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: fornecedor/Create
        [HttpPost]
        public ActionResult<Fornecedor> Create([Bind("Nome,TelefonePrincipal")]Fornecedor item)
        {
            try
            {
                _fornecedorService.Create(item);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }

        // GET: fornecedor/Edit/5
        public IActionResult Edit(Guid id)
        {
            var item = _fornecedorService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: fornecedor/Edit/5
        [HttpPost]
        public IActionResult Edit(Guid id, [Bind("Id,Nome,TelefonePrincipal")]Fornecedor itemIn)
        {
            try
            {
                var item = _fornecedorService.Get(id);

                if (item == null)
                {
                    return NotFound();
                }

                _fornecedorService.Update(id, itemIn);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(itemIn);
        }

        // GET: fornecedor/Delete/5
        public IActionResult Delete(Guid id)
        {
            var item = _fornecedorService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            try
            {
                var item = _fornecedorService.Get(id);
                if (item != null)
                {
                    _fornecedorService.Remove(item.Id);
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
