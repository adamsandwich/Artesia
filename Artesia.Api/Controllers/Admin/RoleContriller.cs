using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Artesia.Api.Controllers
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        // GET api/admin/Role
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}