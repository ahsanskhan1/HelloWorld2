using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AKProducts.Controllers
{
    public class HelloWorldController : ApiController
    {
		// GET: api/HelloWorld
		public IEnumerable<string> Get()
		{
			return new string[] { "Hello World From API" };
		}
	}
}
