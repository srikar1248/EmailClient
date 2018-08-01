using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace EmailWeb.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Index(MailModel model)
        {
            string content = JsonConvert.SerializeObject(model);

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    "<keep your url here>",
                     new StringContent(content, Encoding.UTF8, "application/json"));

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    ViewBag.Message = "Email has been sent successfully.";
            }

            return View();
        }
    }
}