using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Abstractions;
using Service.BL;
using Service.RestApi.Models;

namespace Service.RestApi.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class IncomeController : ControllerBase
    {
        private readonly ILogger<IncomeController> _logger;
        private readonly IIncomesService _incomeService;


        public IncomeController(IIncomesService incomeService, ILogger<IncomeController> logger)
        {
            _incomeService = incomeService;
            _logger = logger;
        }

        [HttpGet("{absid}")]
        public ActionResult<IncomeModelV2[]> Get(int absid)
        {
            try
            {
                return _incomeService.GetClientIncomeTransactions(absid)
                                    .Select(item => new IncomeModelV2(item))
                                    .ToArray();
            } catch (ClientNotFoundException)
            {
                return NotFound();
            }
            catch (ImportNotCompletedException)
            {
                return NotFound();
            }
        }
    }
}
