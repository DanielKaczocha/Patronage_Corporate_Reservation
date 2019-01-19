using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using Patronage.Models;

namespace Patronage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyRegisterController : Controller
    {
        
        [HttpPost]
        public CompanyRegisterReply RegisterReply (Company companyreg)
        {
            Console.WriteLine("In registerCompany");
            CompanyRegisterReply comoregrep = new CompanyRegisterReply();
            CompanyRegister.getInstance().Add(companyreg);
            comoregrep.CompanyName = companyreg.CompanyName;
            comoregrep.PhoneCompany = companyreg.PhoneCompany;
            comoregrep.IdCompany = companyreg.IdCompany;
            comoregrep.CompanyRegisterStatus = "Successful";

            return comoregrep;
        }
        
        [HttpPost("InsertCompany")]
        public IActionResult InsertCompany(Company companyreg)
        {
            Console.WriteLine("In registerCompany");
            CompanyRegisterReply comoregrep = new CompanyRegisterReply();
            CompanyRegister.getInstance().Add(companyreg);
            comoregrep.CompanyName = companyreg.CompanyName;
            comoregrep.PhoneCompany = companyreg.PhoneCompany;
            comoregrep.IdCompany = companyreg.IdCompany;
            comoregrep.CompanyRegisterStatus = "Successful";

            return Ok(comoregrep);
        }

        [Route("company/")]
        [HttpPost("AddCompany")]
        public JsonResult AddCompany(Company companyreg)
        {
            Console.WriteLine("In registerCompany");
            CompanyRegisterReply comoregrep = new CompanyRegisterReply();
            CompanyRegister.getInstance().Add(companyreg);
            comoregrep.CompanyName = companyreg.CompanyName;
            comoregrep.PhoneCompany = companyreg.PhoneCompany;
            comoregrep.IdCompany = companyreg.IdCompany;
            comoregrep.CompanyRegisterStatus = "Successful";

            return Json(comoregrep);
        }
    }
}
