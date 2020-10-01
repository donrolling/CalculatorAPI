using CalculationEngine;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly ILogger<MathController> _logger;

        private readonly IMathEngine _mathEngine;

        public MathController(IMathEngine mathEngine, ILogger<MathController> logger)
        {
            _mathEngine = mathEngine;
            _logger = logger;
        }

        [HttpGet]
        public int Add(int a, int b)
        {
            return _mathEngine.Add(a, b);
        }

        [HttpGet]
        public decimal Add(decimal a, decimal b)
        {
            return _mathEngine.Add(a, b);
        }

        [HttpGet]
        public int Subtract(int a, int b)
        {
            return _mathEngine.Subtract(a, b);
        }

        [HttpGet]
        public decimal Subtract(decimal a, decimal b)
        {
            return _mathEngine.Subtract(a, b);
        }

        [HttpGet]
        public int Multiply(int a, int b)
        {
            return _mathEngine.Multiply(a, b);
        }

        [HttpGet]
        public decimal Multiply(decimal a, decimal b)
        {
            return _mathEngine.Multiply(a, b);
        }

        [HttpGet]
        public decimal Divide(int a, int b)
        {
            return _mathEngine.Divide(a, b);
        }

        [HttpGet]
        public decimal Divide(decimal a, decimal b)
        {
            return _mathEngine.Divide(a, b);
        }
    }
}