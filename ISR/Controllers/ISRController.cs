using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ISR.CL;

namespace ISR.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ISRController : ControllerBase {
        [HttpGet("{amount}/{monthly}")]
        public async Task<decimal> Get(decimal amount, bool monthly) {
            decimal isrCalculated = ISRTax.Calculate(amount, monthly);
            await Logger.Log($"{amount},{monthly},{isrCalculated}");
            return isrCalculated;
        }
    }
}