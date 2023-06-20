using AutoMapper;
using ManagementService.Dtos;
using ManagementService.Models;

namespace ManagementService.Profiles
{
    public class ClassProfiles : Profile
    {
        public ClassProfiles()
        {   
            //source ---> Target

            CreateMap<Class,ClassReadDto>();
            CreateMap<ClassCreateDto,Class>();  
        }
    }
   
}