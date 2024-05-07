using Microsoft.AspNetCore.Mvc;
using ProniaTask.Helpers;

namespace ProniaTask.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {

            List<string> names = ["Gunay", "Inare", "Nazrin"];
            return View(names);

            //var data = SqlHelper.ExecuteQuery("SELECT * FROM Users");
            //List<string> names = [];
            //for(int i=0; i<3; i++)
            //{
            //    names.Add(data.Rows[i][1].ToString());
            //}
            //return View(names);


        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}
