using Microsoft.AspNetCore.Mvc;
using MVCDog.Data;
using MVCDog.Domain;
using MVCDog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDog.Controllers
{
    public class GuineaPigController : Controller
    {
        
           
        private readonly ApplicationDbContext context;
        public GuineaPigController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(GuineaPigCreateViewModel bindingModel)
        {
            if (ModelState.IsValid)
            {
                GuineaPig guineaPigFromDb = new GuineaPig
                {
                    Name = bindingModel.Name,
                    Age = bindingModel.Age,
                    Picture = bindingModel.Picture,
                };
                context.GuineaPigs.Add(guineaPigFromDb);
                context.SaveChanges();
                return this.RedirectToAction("Success");
            }
            return this.View();
        }
        public IActionResult Success()
        {
            return this.View();
        }

       // public IActionResult All()
        //{
          //  List<GuineaPigAllViewModel> dogs = context.Dogs.Select(dogFromDb => new GuineaPigAllViewModel
           // {
               // Name = guineaPigFromDb.Name,
               // Age = guineaPigFromDb.Age,
//Picture = guineaPigFromDb.Picture
           // }).ToList();
           // return this.View(guineaPigs);
      //  }


    }
}