using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyDbContext _dbContext;
        public CompanyController(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            ViewData["CompanyName"] = company.Name;

            var viewModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = company.IsVisible
            };

            return View("CompanyAdded", viewModel);
        }

        [HttpGet("CompanyList")]
        public IActionResult CompanyList()
        {
            
            var results = _dbContext.Items.ToList();
            return Ok(results);
        }

    }
}
