using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableDbContextSample.Contexts;
using TableDbContextSample.Entities;

namespace TableDbContextSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController : ControllerBase
    {
        private readonly ILogger<TableController> _logger;
        private readonly AppDbContext _dbContext;

        public TableController(ILogger<TableController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var table = new Table { Columns = new List<Column>() };

            table.Columns.Add(new Column { Name = "Column1", Table = table });
            table.Columns.Add(new Column { Name = "Column2", Table = table });

            await _dbContext.Tables.AddAsync(table);

            return Ok();
        }
    }
}
