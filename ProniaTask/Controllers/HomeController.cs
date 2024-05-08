using Microsoft.AspNetCore.Mvc;
using ProniaTask.DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProniaTask.ViewModels.Categories;

namespace ProniaTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaContext _context;

        public HomeController(ProniaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //var data= await _context.Categories.Where(c=>c.Name.Length<5).ToListAsync();
            //var data= await _context.Categories.Take(5).ToListAsync();
            //var data= await _context.Categories
            //    .OrderByDescending(x=>x.Id)
            //    .Take(5)
            //    .ToListAsync();
            //return View(data);

            //Delete
            var data = await _context.Categories
            .Where(x => x.isDeleted == false)
             .Select(x => new GetCategoryVM
             {
                Id = x.Id,
                Name = x.Name
             })
             .ToListAsync();
            return View(data);
        }

        public async Task<IActionResult> Test(int? id)
        {
            if (id == null || id < 1) return BadRequest();
            var cat = await _context.Categories.FindAsync(id);
            if (id == null) return NotFound();
            _context.Remove(cat);
            await _context.SaveChangesAsync();
            return Content(cat.Name);
        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}
