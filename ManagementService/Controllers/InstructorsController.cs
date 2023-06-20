using System.Collections.Generic;
using AutoMapper;
using ManagementService.Data.Abstract;
using ManagementService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController :ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IInstructorRepo _repo;

        public InstructorsController(IMapper mapper, IInstructorRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public  ActionResult<List<Instructor>> GetInstructorS()
        {
            return Ok(_repo.GetAll());

        }

    }
}