using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EMPRESA_QBE.Models;
using EMPRESA_QBE.Data;
using Microsoft.EntityFrameworkCore;

namespace EMPRESA_QBE.Controllers
{
    [Route("[controller]")]
    public class AdministradorController : Controller
    {
        private readonly ILogger<AdministradorController> _logger;
        private readonly ApplicationDbContext _context;

        public AdministradorController(ApplicationDbContext context,
            ILogger<AdministradorController> logger)
        {
            _context = context;
            _logger = logger;
        }

       [Route("ruta1")]
        public IActionResult Administrador(){
            return View();
        }

        [Route("ruta2")]
        public IActionResult RegistrarProd(){
            return View();
        }        

        [HttpPost]
        public async Task<IActionResult> Registrar(Producto objProducto)
        {
            _context.Add(objProducto);
            _context.SaveChanges();
            ViewData["Message"] = "Se registro el Producto";
            return View("Administrador");
       
        }

    }
}