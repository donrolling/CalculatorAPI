using CalculationEngine.Interfaces;
using CalculationEngine.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculationAPI.Controllers
{
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly ILogger<MathController> _logger;

        private readonly IMathEngine _mathEngine;

        public MathController(IMathEngine mathEngine, ILogger<MathController> logger)
        {
            _mathEngine = mathEngine;
            _logger = logger;
        }

        [HttpPost]
        [Route("api/math/integers")]
        public decimal Post(CalculateIntegersOperation calculateOperation)
        {
            return _mathEngine.Calculate(calculateOperation);
        }

        [HttpPost]
        [Route("api/math/decimals")]
        public decimal Post(CalculateDecimalsOperation calculateOperation)
        {
            return _mathEngine.Calculate(calculateOperation);
        }
    }
}