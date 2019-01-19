using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Patronage.Models;

namespace Patronage.Controllers
{
    [Route("api/[controller]")]
    public class CompanyRetriveController : Controller
    {
        [HttpGet]
        public List<Company> GetCompanys()
        {
            return CompanyRegister.getInstance().getCompanys();
        }
        [HttpGet("GetCompanysRecords")]
        public JsonResult getCompanysRecords()
        {
            return Json(CompanyRegister.getInstance().getCompanys());
        }
    }
}
