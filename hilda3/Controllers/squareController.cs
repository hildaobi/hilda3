using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hilda3.Controllers
{
    public class squareController : ApiController
    {
        //Get/api/square/id

        public int Get (int id)
        {
            int square = id * id;
            return square;
        }

    }
   
}
