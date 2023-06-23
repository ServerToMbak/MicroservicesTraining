using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controller
{
    [Route("api/m/[Controller]")]
    [ApiController]
    public class ManagementsController : ControllerBase
    {
        public ManagementsController()
        {
        
        }
        [HttpPost]
        public ActionResult TextInBoundConnection()
        {
            Console.WriteLine("ManagementService get comminicated with CommandService");
            return Ok("ManagementService Accessed to the CommandService");
        }

    }
    

}