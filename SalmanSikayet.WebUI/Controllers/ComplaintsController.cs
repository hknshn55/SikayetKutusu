using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SalmanSikayet.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.WebUI.Controllers
{
    public class ComplaintsController : Controller
    {
        HttpClient client = new HttpClient();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ComplaintModel complaint)
        {
            
            if (ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(complaint), Encoding.UTF8, "application/json");
                client.BaseAddress = new Uri("http://localhost:25011");
                var re = client.PostAsync($"{"/api/Complaints"}", content);
                ViewBag.SuccessMessage = "Mesajiniz iletildi.";
                return View();
            }

            ModelState.AddModelError("","Lütfen şikayet ve öneri alanını boş geçmeyiniz.");
            return View(complaint);
        }
    }
}
