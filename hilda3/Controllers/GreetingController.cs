using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hilda3.Controllers
{
    public class GreetingController : ApiController
    {
        public string Get(int id)
        {
            return "Greetings to" + " " + id + " " + "people!";
        }
    }
    public string Post() 
    {
        return "Hello World";
    }
}
