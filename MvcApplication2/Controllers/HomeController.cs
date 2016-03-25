using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
using Newtonsoft.Json;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public string ClientAjaxLoader()
        {
            ClientModel cm = new ClientModel();
            ClientList cl = new ClientList();
            cl.Clients.AddRange(cm.GetClients());
            var jsonData = JsonConvert.SerializeObject(cl);
            return jsonData;
        }


    }
}
