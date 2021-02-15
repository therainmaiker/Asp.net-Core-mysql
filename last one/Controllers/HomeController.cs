using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace last_one.Controllers
{
    public class HomeController : Controller
    {
       
        public string ana()
        {
            return "ana home";
            
        }

        public IActionResult index()
        {

            return View();
        }


        public string getall(int ID)
        {

            return $"ara liya {ID} khobzat";


        }


        public string insert(string name, int ix)
        {

            return $"insert your {name} and your id is {ix}";

        }
        
    }
}
