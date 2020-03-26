
using System.ComponentModel.DataAnnotations;

namespace Onion.Domain.Entities
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
