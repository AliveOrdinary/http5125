using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myFirstASPNETProject.Controllers
{
    public class MultiplyController : ApiController
    {
        public int Get (int id)
        {
            int product = id * 5;
            return product;
        }
    }
}
