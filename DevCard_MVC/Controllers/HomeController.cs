using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Diagnostics;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "Silver"),
            new Service(2, "Plutin"),
            new Service(3, "Gold"),
            new Service(4, "Dimon")
        };

        private readonly List<Color> _colors = new List<Color>
        {
            new Color(1, "Red"),
            new Color(2,"Blue"),
            new Color(3,"Yellow"),
            new Color(4, "Black")
        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                 Services = new SelectList(_services, "Id","Name"),
                 Colors = new SelectList(_colors,"Id","Name")
            };
            return View(model);

        }

        //Other Methode for Give Information from Contact Form
        [HttpPost]
        //Validation
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            model.Colors = new SelectList(_colors, "Id", "Name");
            if (!ModelState.IsValid)
            {
                //ViewData["error"]
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. دوباره تلاش کنید";
                return View(model);
            }
            //Clear After Send
            ModelState.Clear();
            model = new Contact();
            ViewBag.success = "پیام شما با موفقیت ارسال شد";
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
