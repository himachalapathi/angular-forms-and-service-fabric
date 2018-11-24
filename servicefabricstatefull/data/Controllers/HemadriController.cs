using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace data.Controllers
{
    class Hemadri
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int id { get; set; }
        public string address { get; set; }
    }
    [Route("api/[controller]")]
    public class HemadriController : Controller
    {
        List<Hemadri> Hemadris = new List<Hemadri>();
        public IActionResult Index()
        {
            Hemadris.Add(new Hemadri() { Fname = "naveen", Lname = "naresh", id = 1, address = "ap" });
            Hemadris.Add(new Hemadri() { Fname = "raja", Lname = "mahesh", id = 2, address = "ka" });
            Hemadris.Add(new Hemadri() { Fname = "sathi", Lname = "veda", id = 3, address = "tn" });
            return new JsonResult(Hemadris);
        }
    }
}