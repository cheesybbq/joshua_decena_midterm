using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Midterms.Models;

namespace Midterms.Controllers
{
    public class ProductController : ApiController
    {
        static List<Product> collections = new List<Product>();

        public List<Product> Get()
        {
        return collections;
        }
        public Product Get(int index)
        {
            return collections[index];
        }

        public Product Post(string id, int code, string name, string description, string categoryid, string color, string size, double price)
        {
            Product a = new Product();
            a.ID = id;
            a.Code = code;
            a.Name = name;
            a.Description = description;
            a.CategoryID = categoryid;
            a.Color = color;
            a.Size = size;
            a.Price = price;
            collections.Add(a);
            return a;
        }

        public Product Put (int index, string id, int code, string name, string description, string categoryid, string color, string size, double price)
        {
            var a = collections[index];
            a.ID = id;
            a.Code = code;
            a.Name = name;
            a.Description = description;
            a.CategoryID = categoryid;
            a.Color = color;
            a.Size = size;
            a.Price = price;
            collections.Add(a);
            return a;
        }

        public string Delete(int index)
        {
            collections.RemoveAt(index);
            return "Deleted";
        }

        public ProductController()
        {
            if(collections.Count<1)
            { 
            Product a = new Product();
            a.ID = "FirstProduct";
            a.Code = 1;
            a.Name = "FirstHoodie";
            a.Description = "Hoodie";
            a.CategoryID = "Hoodies and Sweatshirts";
            a.Color = "Black";
            a.Size = "Small";
            a.Price = 250;
            collections.Add(a);
            Product b = new Product();
            b.ID = "SecondProduct";
            b.Code = 2;
            b.Name = "SecondHoodie";
            b.Description = "Hoodie";
            b.CategoryID = "Hoodies and Sweatshirts";
            b.Color = "Black";
            b.Size = "Medium";
            b.Price = 350;
            collections.Add(b);
            Product c = new Product();
            c.ID = "ThirdProduct";
            c.Code = 3;
            c.Name = "ThirdHoodie";
            c.Description = "Hoodie";
            c.CategoryID = "Hoodies and Sweatshirts";
            c.Color = "Black";
            c.Size = "Large";
            c.Price = 450;
            collections.Add(c);
            }
        }
    }
}
