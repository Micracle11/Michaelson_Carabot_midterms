using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Michaelson_Carabot_midterms.Models;

namespace Michaelson_Carabot_midterms.Controllers
{
    public class ReqController : ApiController
    {
        static List<Products> collections = new List<Products>();
        public List<Products> Get()
        {
            return collections;
        }
        public Products Get(int index)
        {
            return collections[index]; 
        }
        public Products Post(string id, int code, string color, string name, string description, string categoryid, string size, int price)
        {
            Products a = new Products();
            a.ID = id;
            a.Code = code;
            a.Color = color;
            a.Name = name;
            a.Description = description;
            a.CategoryID = categoryid;
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

        public ReqController()
        {
            if (collections.Count < 1)
            {
                Products a = new Products();
                a.ID = "AA";
                a.Code = 01;
                a.Color = "Black";
                a.Name = "Prod One";
                a.Description = "Denim Shorts";
                a.CategoryID = "Shorts";
                a.Size = "Medium";
                a.Price = 200;
                collections.Add(a);
                Products b = new Products();
                b.ID = "AA";
                b.Code = 02;
                b.Color = "Blue";
                b.Name = "Prod Two";
                b.Description = "Denim Shorts";
                b.CategoryID = "Shorts";
                b.Size = "Large";
                b.Price = 250;
                collections.Add(b);
                Products c = new Products();
                c.ID = "AB";
                c.Code = 01;
                c.Color = "White";
                c.Name = "Prod Three";
                c.Description = "Plain Shirt";
                c.CategoryID = "T-Shirt";
                c.Size = "Medium";
                c.Price = 150;
                collections.Add(c);
                Products d = new Products();
                d.ID = "AB";
                d.Code = 02;
                d.Color = "Gray";
                d.Name = "Prod Four";
                d.Description = "Plain Shirt";
                d.CategoryID = "T-Shirt";
                d.Size = "Large";
                d.Price = 200;
                collections.Add(d);
            }
        }
    }
}
