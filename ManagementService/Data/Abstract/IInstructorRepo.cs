using System.Collections.Generic;
using ManagementService.Models;

namespace ManagementService.Data.Abstract
{
    public interface IInstructorRepo
    {
        void AddInstructor(Instructor ins);

        void DeleteInstructor(Instructor ins);
        List<Instructor> GetAll(); 
        Instructor  GetInstructorById(int id);
    }
}