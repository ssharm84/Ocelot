using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApi.Controllers
{
    [ApiController]
    [Route("api/currencies")]
    public class ValuesController : ControllerBase
    {
        [HttpGet,Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"usd","inr", "jpy"};
        }
    }
}
