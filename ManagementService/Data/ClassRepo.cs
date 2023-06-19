using System;
using System.Collections.Generic;
using System.Linq;
using ManagementService.Data.Abstract;
using ManagementService.Models;

namespace ManagementService.Data
{
    public class ClassRepo : IClassRepo
    {
        private readonly AppDbContext _context;

        public ClassRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreataClass(Class cl)
        {
            if(cl == null )
            {
                throw new ArgumentNullException(nameof(cl));
            }

            _context.Classes.Add(cl);
        }

        public IEnumerable<Class> GetAllClasses()
        {
           return _context.Classes.ToList();
        }

        public Class GetClassById(int id)
        {
            return _context.Classes.FirstOrDefault( p => p.Id == id );
        }

        public bool SaveChanges()
        {
           
           return  (_context.SaveChanges() >= 0);
        }
    }
}