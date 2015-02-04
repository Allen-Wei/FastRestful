using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FastRestful.Areas.API
{
    public class UtilsController : ApiController
    {
        public string Get(string url)
        {
            return url;
        }
    }
}
