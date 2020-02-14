using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IntroTdd.Web.Models;
using IntroTdd.Domain;

namespace IntroTdd.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new CuentaModel());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Depositar(CuentaModel cuenta)
        {
            if (ModelState.IsValid)
            {
                
                var saldo = cuenta.Saldo;
                var monto = cuenta.Monto;

                ModelState.Clear();

                CuentaBancaria cuentaBancaria = new CuentaBancaria(saldo);

                cuentaBancaria.Depositar(monto);

                cuenta.Saldo = cuentaBancaria.SaldoActual;
                cuenta.Monto = 0;
            }

            return View("Index",cuenta);
        }
    }
}
