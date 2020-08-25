using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Abstractions;
using Service.RestApi.Models;

namespace Service.RestApi.Controllers.V1
{
    [ApiController]
    [ApiVersionNeutral]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;
        private readonly IIncomesService _incomeService;


        public TaskController(IIncomesService incomeService, ILogger<TaskController> logger)
        {
            _incomeService = incomeService;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<TaskModel[]> Get()
        {
            return _incomeService.GetTasks()
                                .Select(item => new TaskModel(item))
                                .ToArray();
        }
    }
}
