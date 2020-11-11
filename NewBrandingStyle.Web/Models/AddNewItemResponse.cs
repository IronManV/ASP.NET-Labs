using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Models
{
    public class AddNewItemResponse
    {
        public bool success { get; set; }
        public CompanyModel addedCompany { get; set; }
    }
}
