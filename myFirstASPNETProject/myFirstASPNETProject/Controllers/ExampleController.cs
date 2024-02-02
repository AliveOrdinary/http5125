using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myFirstASPNETProject.Controllers
{
    public class ExampleController : ApiController
    {
        public int Get()
        {
            return 5;
        }
    }
}
