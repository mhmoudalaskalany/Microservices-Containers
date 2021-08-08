using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Leave.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeavesController : ControllerBase
    {
        [HttpGet("Get")]
        public Leave GetAsync()
        {
            return new()
            {
                Date = DateTime.Now.AddDays(1),
                Type = "Annual"
            };
        }

        [HttpGet("GetAll")]
        public IEnumerable<Leave> GetAllAsync()
        {
            return Enumerable.Range(1, 5).Select(index => new Leave()
                {
                    Date = DateTime.Now.AddDays(index),
                    Type = "Urgent",
                })
                .ToArray();
        }
    }
}