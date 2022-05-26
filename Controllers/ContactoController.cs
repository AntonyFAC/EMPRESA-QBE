using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EMPRESA_QBE.Models;
using EMPRESA_QBE.Data;
using EMPRESA_QBE.Integration.SendMailIntegration;

namespace EMPRESA_QBE.Controllers
{

    public class ContactoController: Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly SendMailIntegration _sengrid;

        public ContactoController(ApplicationDbContext context,
            ILogger<ContactoController> logger,
            SendMailIntegration sengrid
            )
        {
            _context = context;
            _logger = logger;
            _sengrid = sengrid;
        }

        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Contacto objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
            
            await _sengrid.SendMail(objContacto.Email,
                objContacto.Name,
                "Bienvenido al e-comerce",
                "Revisaremos su consulta en breves momentos y le responderemos",
                SendMailIntegration.SEND_SENDGRID);


            ViewData["Message"] = "Su comentario fue enviado!, Gracias.";
            return View("Index");
        }
    }
    
}