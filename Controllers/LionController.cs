using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Lions.Controllers     
{
    public class LionController : Controller  
    {

        public static List<string> Facts = new List<string>() {
            "Not all male lions have a mane",
            "Watch out",
            "Lions are the second largest cat species",
            "Male lions defend the pride's territory while female lions do all the work",
            "Lions in the wild live for around 12 years",
            "Lions rest for around 20 hours a day"
        };
        public static Random rand = new Random();

        [HttpGet]       
        [Route("")] 
        public IActionResult Index()
        {
            int randIndex = rand.Next(0, Facts.Count);
            ViewBag.Fact = Facts[randIndex];
            return View();
        }

        [HttpGet]       
        [Route("facts")] 
        public IActionResult AllFacts()
        {
            ViewBag.Facts = Facts;
            return View("AllFacts");
        }

    }
}