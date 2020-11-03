using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_4.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Lab_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDbContext dbContext;
        public HomeController(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult Books() => View(dbContext.Books.AsEnumerable<Book>());

        [HttpGet]
        public IActionResult Students() => View(dbContext.Students.AsEnumerable<Student>());

        [HttpGet]
        public IActionResult AddBook() => View();

        [HttpPost]
        public IActionResult AddBook(AddBookViewModel model)
        {
            Book book = new Book
            {
                Name = model.Name,
                Author = model.Author,
                Count = model.Count
            };
            dbContext.Add<Book>(book);
            dbContext.SaveChanges();
            return RedirectToAction("AddBook");
        }
    }
}
