using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _ClienteService;

        public ClienteController(IClienteService ClienteService)
        {
            _ClienteService = ClienteService;
        }

        // GET: Cliente
        public ActionResult<List<Cliente>> Index()
        {
            return View(_ClienteService.Get());
        }

        // GET: Cliente/Details/5
        public ActionResult<Cliente> Details(Guid id)
        {
            var Cliente = _ClienteService.Get(id);
            if (Cliente == null)
            {
                return NotFound();
            }

            return View(Cliente);
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult<Cliente> Create([Bind("Nome,Documento,Endereco,Bairro,Cidade,Estado,TelefonePrincipal,TelefoneSecundario")]Cliente Cliente)
        {
            try
            {
                _ClienteService.Create(Cliente);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }

        // GET: Cliente/Edit/5
        public IActionResult Edit(Guid id)
        {
            var Cliente = _ClienteService.Get(id);
            if (Cliente == null)
            {
                return NotFound();
            }

            return View(Cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public IActionResult Edit(Guid id, [Bind("Id,Nome,Documento,Endereco,Bairro,Cidade,Estado,TelefonePrincipal,TelefoneSecundario")]Cliente ClienteIn)
        {
            try
            {
                var Cliente = _ClienteService.Get(id);

                if (Cliente == null)
                {
                    return NotFound();
                }

                _ClienteService.Update(id, ClienteIn);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(ClienteIn);
        }

        // GET: Cliente/Delete/5
        public IActionResult Delete(Guid id)
        {
            var Cliente = _ClienteService.Get(id);
            if (Cliente == null)
            {
                return NotFound();
            }

            return View(Cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            try
            {
                var Cliente = _ClienteService.Get(id);
                if (Cliente != null)
                {
                    _ClienteService.Remove(Cliente.Id);
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