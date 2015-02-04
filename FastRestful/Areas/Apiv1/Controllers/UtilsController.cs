using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace FastRestful.Areas.Apiv1.Controllers
{
    public class UtilsController : Controller
    {
      
        public string ReqUrl(string url)
        {
            Response.AddHeader("Access-Control-Allow-Origin", "*");
            var req = WebRequest.Create(url);
            var rep = "";
            using (var reader = new StreamReader (req.GetResponse().GetResponseStream()))
            {
                rep = reader.ReadToEnd();
            }
            Response.ContentType = "text/html";
            return rep;
        }

    }
}
