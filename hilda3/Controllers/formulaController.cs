using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hilda3.Controllers
{
    public class formulaController : ApiController
    {
        public IEnumerable<int> Get(int id) {
            int add = id + 5;//echos out addition of 5 to an input id
            int mul = id * 5;//echos out multiplication of 5 to an input id
            int div = id / 5;//echos out division of 5 to an input id
            int minus = id - 5;//echos out subtraction of 5 to an input id
            {
                return new int[] { add, mul,div,minus };
            }
        }
       
    }

}
