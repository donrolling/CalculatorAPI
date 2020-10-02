using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CalculationAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}