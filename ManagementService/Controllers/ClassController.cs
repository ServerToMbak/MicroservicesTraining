using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ManagementService.Data.Abstract;
using ManagementService.Dtos;
using ManagementService.Models;
using ManagementService.SyncDataService.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private  IClassRepo _classRepo;
        private  IMapper _mapper;
        private  ICommandDataClient _commandDataClient;

        public ClassController(IClassRepo classRepo, IMapper mapper, ICommandDataClient commandDataClient)
        {
                _classRepo = classRepo;
                _mapper = mapper ;
                _commandDataClient = commandDataClient;

        }
        [HttpGet]
        public ActionResult<IEnumerable<ClassReadDto>> GetClasses() //https://localhost:5001/api/class/
        {
            Console.WriteLine("---> Getting Classes  ");

            var classItems = _classRepo.GetAllClasses();

            return Ok(_mapper.Map<IEnumerable<ClassReadDto>>(classItems));
        }

        [HttpGet("{id}", Name = "GetClassById")]
        public ActionResult<ClassReadDto> GetClassById(int id) //https://localhost:5001/api/class/1
        {

            var classItem = _classRepo.GetClassById(id);

            if(classItem != null)
            {
                return Ok(_mapper.Map<ClassReadDto>(classItem));
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<ClassReadDto>> CreateClass(ClassCreateDto classCreateDto) 
        {   
                var classModel = _mapper.Map<Class>(classCreateDto);// Mapping classCreateDto Object to Class object
                _classRepo.CreataClass(classModel);
                _classRepo.SaveChanges();

                var classReadDto =  _mapper.Map<ClassReadDto>(classModel); // Mapping class object to ClassReadDto
                
                try
                {
                    await _commandDataClient.SendManagementToCommand(classReadDto);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"--> Could Not Send Synchronusly: {ex.Message}");
                }
                return CreatedAtRoute(nameof(GetClassById), new {Id = classReadDto.Id}, classReadDto);
               // return Ok(classReadDto);
        }

    }
}