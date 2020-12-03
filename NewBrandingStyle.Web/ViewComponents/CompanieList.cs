using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;

namespace NewBrandingStyle.Web.ViewComponents
{
    public class CompanieList : ViewComponent
    {
        private readonly CompanyDbContext _dbContext;

        public CompanieList(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var companies = _dbContext.Items.ToList();

            return View("Index", companies);
        }
    }
}
