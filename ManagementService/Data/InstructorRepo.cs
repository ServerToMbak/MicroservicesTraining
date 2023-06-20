using System;
using System.Collections.Generic;
using System.Linq;
using ManagementService.Data.Abstract;
using ManagementService.Models;

namespace ManagementService.Data
{
    public class InstructorRepo : IInstructorRepo
    {
        private readonly AppDbContext _context;

        public InstructorRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddInstructor(Instructor ins)
        {
            if(ins == null)
            {
                throw new ArgumentNullException();
            }
              _context.Instructors.Add(ins);
        }

        public void DeleteInstructor(Instructor ins)
        {
            _context.Instructors.Remove(ins);
        }

        public List<Instructor> GetAll()
        {
            return _context.Instructors.ToList();
        }

        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors.FirstOrDefault( p => p.Id == id);
        }
    }
}