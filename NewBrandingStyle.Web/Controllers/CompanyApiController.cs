using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Database;
using NewBrandingStyle.Web.Entities;

namespace NewBrandingStyle.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyApiController : ControllerBase
    {

        private readonly CompanyDbContext _dbContext;
        public CompanyApiController(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public AddNewItemResponse Post(CompanyModel company)
        {
            var entity = new ItemEntity
            {
                Name = company.Name,
                Description = company.Description,
                IsVisible = company.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            return new AddNewItemResponse()
            {
                success = true,
                addedCompany = company
            };
        }

        

        
    }
}
