using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using Onion.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Infrastructure.MockDbService.Services
{
    public class MsSQLDbService : IStudentDbService
    {
        StudentDbContext db = new StudentDbContext();
        public IEnumerable<Student> GetStudents()
        {
            
            return db.Students.ToList();
        }

        public bool EnrollStudent(Student newStudent, int semestr)
        {
            db.Students.Add(newStudent);
            db.SaveChanges();
            return true;
        }
    }
}
