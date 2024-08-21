using Bank_transection_using_crud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bank_transection_using_crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly TransectionDB tDb;

        //    private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(TransectionDB tDb)
        {
            this.tDb = tDb;
        }




        public IActionResult Index()
        {
            var stddata = tDb.Transections.ToList();
            return View(stddata);
        }
        

        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Create(Transection t)
        {
            if (ModelState.IsValid)
            {
                tDb.Transections.Add(t);
                tDb.SaveChanges();
                return RedirectToAction("index", "Home");

            }
            return View(t);
        }

        public IActionResult Details(int id)
        {
            var stddata = tDb.Transections.Find(id);
            return View(stddata);
        }

        public IActionResult Edit(int id)
        {
            var std = tDb.Transections.Find(id);
            return View(std);
        }
        [HttpPost]
        public IActionResult Edit(Transection t)
        {
            if (ModelState.IsValid)
            {
                tDb.Transections.Update(t);
                tDb.SaveChanges();
                return RedirectToAction("index", "Home");
            }



            return View(t);
        }

        public IActionResult Delete(int id)
        {
            var std = tDb.Transections.Find(id);
            return View(std);
        

          
        }
        [HttpPost]
        public IActionResult Delete(int id,Transection t)
        {
            var std = tDb.Transections.Find(id);
            if (std != null)
            {
                tDb.Transections.Remove(std);
            }
            tDb.SaveChanges();
            return RedirectToAction("index", "Home");
            return View(std);



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