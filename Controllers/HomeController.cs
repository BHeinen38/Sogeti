 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Baileys_Order_API.Models;
using Baileys_Order_API.Data;

namespace Baileys_Order_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //this will return the view with a list of orders in a list form
            return View(_context.Orders.ToList());
        }

        //HTTP Get Method
        [HttpGet]
        public IActionResult Create()
        {
            //this will return the create view
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (_context.Orders.Where(x => x.Name == order.Name).Any()) //throw and exception if the order has already been placed
                throw new Exception("Sorry this order already exist"); 


            if (ModelState.IsValid) 
            {
                _context.Add(order); //Add the order to the database 
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var order = _context.Orders.Find(id); //look 
            if (order == null)
            {
                return NotFound();
            }
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //HTTP GET
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var order = _context.Orders.Find(id); //look in the data base for the correct ID

            if (order == null)
                return NotFound();


            return View(order);

        }
        //There is a bug but was going to use this to edit the quanitity but I am running out of time with 2 hour window so will leave so you can see
        //This was going to be used to edit the quantity of an order
        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Update(order.Quantity);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

