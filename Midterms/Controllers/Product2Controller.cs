using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Midterms.Models;

namespace Midterms.Controllers
{
    public class Products2Controller : ApiController
    {
        static List<Products2> collections = new List<Products2>();

        public List<Products2> Get()
        {
            return collections;
        }
        public Products2 Get(int index)
        {
            return collections[index];
        }

        public Products2 Post(string id, int code, string name, string description, string categoryid, string color, string size, double price)
        {
            Products2 aa = new Products2();
            aa.ID = id;
            aa.Code = code;
            aa.Name = name;
            aa.Description = description;
            aa.CategoryID = categoryid;
            aa.Color = color;
            aa.Size = size;
            aa.Price = price;
            collections.Add(aa);
            return aa;
        }

        public Products2 Put(int index, string id, int code, string name, string description, string categoryid, string color, string size, double price)
        {
            var aa = collections[index];
            aa.ID = id;
            aa.Code = code;
            aa.Name = name;
            aa.Description = description;
            aa.CategoryID = categoryid;
            aa.Color = color;
            aa.Size = size;
            aa.Price = price;
            collections.Add(aa);
            var response = Request.CreateResponse<Products2>(HttpStatusCode.Accepted, aa);
            return aa;
        }

        public string Delete(int index)
        {
            collections.RemoveAt(index);
            return "Deleted";
        }

        public Products2Controller()
        {
            if (collections.Count < 1)
            {
                Products2 aa = new Products2();
                aa.ID = "AA";
                aa.Code = 1;
                aa.Name = "AAJeans";
                aa.Description = "Jeans";
                aa.CategoryID = "Jeans and Pants";
                aa.Color = "Light";
                aa.Size = "29";
                aa.Price = 250;
                collections.Add(aa);
                Products2 bb = new Products2();
                bb.ID = "BB";
                bb.Code = 2;
                bb.Name = "BBJeans";
                bb.Description = "Jeans";
                bb.CategoryID = "Jeans and Pants";
                bb.Color = "Light";
                bb.Size = "30";
                bb.Price = 350;
                collections.Add(bb);
                Products2 cc = new Products2();
                cc.ID = "CC";
                cc.Code = 3;
                cc.Name = "CCJeans";
                cc.Description = "Jeans";
                cc.CategoryID = "Jeans and Pants";
                cc.Color = "Black";
                cc.Size = "25";
                cc.Price = 450;
                collections.Add(cc);
            }
        }
    }
}
