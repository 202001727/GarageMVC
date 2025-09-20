using System.Diagnostics;
using GarageMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly Garage miGaraje;

        public HomeController()
        {
            
            miGaraje = new Garage(1, "Garaje de KERYN G CARIAS", 10);
        }

        public IActionResult Index()
        {
            
            miGaraje.ingresarAuto(new Auto(1, "TOYOTA", "HIS 9778"));
            miGaraje.ingresarAuto(new Auto(2, "HONDA", "PCF 0011"));
            miGaraje.ingresarAuto(new Auto(3, "FORD", "XDP 7777"));

            
            return View(miGaraje);
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
    }
}