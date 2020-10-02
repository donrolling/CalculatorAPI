using CalculationEngine.Interfaces;
using CalculationEngine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculationAPI.Controllers
{
    [Route("api/[controller]")]
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
        public decimal Post(CalculateOperation calculateOperation)
        {
            return _mathEngine.Calculate(calculateOperation);
        }
    }
}