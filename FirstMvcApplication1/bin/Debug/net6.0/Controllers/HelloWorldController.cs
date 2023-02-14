using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace FirstMvcApplication.Controllers
{
    public class HelloWorldController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
        public string Welcome(int id,string firstname,string lastname)
        {
            return $"This is the Welcome action method...{id} - {firstname} {lastname}";
        }

        //Fetch record from class
        public string stringout(int id,Student stud)
        {
            return $"Hello {id} {stud.firstname} {stud.lastname}";
        }
        //Return Json Value
        public IActionResult Jsonout(int id,Student stud)
        {
            var obj = new { Id = id, Student = stud };
            return Json(obj);
        }
        //Class
        public class Student
        {
            public string firstname {get; set;}
            public string lastname { get; set; }
        }
    }
}
