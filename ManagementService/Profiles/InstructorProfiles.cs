using AutoMapper;
using ManagementService.Dtos;
using ManagementService.Models;

namespace ManagementService.Profiles
{
    public class InstructorProfiles : Profile
    {
        public InstructorProfiles()
        {
            //Source --> Target
            CreateMap<Instructor, InstructorReadDto>();
            CreateMap<InstructorCreateDto, Instructor>();
        }
    }
}