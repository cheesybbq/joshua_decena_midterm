using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Midterms.Controllers
{
    public class DefaultController : ApiController
    {
        public string Get()
        {
            return "I am a Get Operation";
        }
        public string Get(int ProductCode)
        {
            return "Product Codes";
        }
        public string Get(string CategoryCode)
        {
            return "Categories";
        }
        public string Post()
        {
            return "I am a Post Operation";
        }
        public string Put()
        {
            return "I am a PUT Operation";
        }
        public string Delete()
        {
            return "I am a Delete Operation";
        }
    }
}
