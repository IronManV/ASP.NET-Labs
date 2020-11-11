﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyApiController : ControllerBase
    {
      public AddNewItemResponse Post(CompanyModel company)
        {
            return new AddNewItemResponse()
            {
                success = true,
                addedCompany = company
            };
        }
    }
}