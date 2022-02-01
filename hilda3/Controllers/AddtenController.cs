using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hilda3.Controllers
{
    public class AddtenController : ApiController
    {
        public int Get(int id) 
        {
            int add = id + 10;
            return add;
            
        }
    }
}
