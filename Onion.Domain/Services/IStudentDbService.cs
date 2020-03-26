using Onion.Domain.Entities;
using System.Collections.Generic;

namespace Onion.Domain.Services
{
    public interface IStudentDbService
    {
        public IEnumerable<Student> GetStudents();
        public bool EnrollStudent(Student newStudent, int semestr);
    }
}
