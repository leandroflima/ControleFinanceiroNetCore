using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: Cliente
        public ActionResult<List<Cliente>> Index()
        {
            return View(_clienteService.Get());
        }

        // GET: Cliente/Details/5
        public ActionResult<Cliente> Details(Guid id)
        {
            var item = _clienteService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult<Cliente> Create([Bind("Nome,Documento,Endereco,Bairro,Cidade,Estado,TelefonePrincipal,TelefoneSecundario")]Cliente item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clienteService.Create(item);

                    return RedirectToAction(nameof(Index));
                }
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
            var item = _clienteService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public IActionResult Edit(Guid id, 
            [Bind("Id,Nome,Documento,Endereco,Bairro,Cidade,Estado,TelefonePrincipal,TelefoneSecundario")]Cliente itemIn)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = _clienteService.Get(id);

                    if (item == null)
                    {
                        return NotFound();
                    }

                    _clienteService.Update(id, itemIn);

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(itemIn);
        }

        // GET: Cliente/Delete/5
        public IActionResult Delete(Guid id)
        {
            var item = _clienteService.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = _clienteService.Get(id);
                    if (item != null)
                    {
                        _clienteService.Remove(item.Id);
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