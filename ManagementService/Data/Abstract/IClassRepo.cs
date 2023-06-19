using System.Collections.Generic;
using ManagementService.Models;

namespace ManagementService.Data.Abstract
{
    public interface IClassRepo
    {
        bool SaveChanges();

        IEnumerable<Class> GetAllClasses();

        Class GetClassById(int Id);

        void CreataClass(Class clss);

    
    }

}