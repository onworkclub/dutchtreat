using System;
using System.Collections.Generic;
using System.Linq;
using MyProject.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                //all good!
                _mailService.SendMessage("kjfschuite@hotmail.com", model.Subject,model.Message);
 
                ViewBag.UserMessage = "Mail Send"; 
               
            }
            else
            {
                //show the erros
            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }


}
