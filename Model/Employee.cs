
using System.ComponentModel.DataAnnotations;

namespace Demo_ASPcore_API.Model
{
    public class Employee
    {
        [Key]//key attribute and it will generate a akey
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Designation { get; set; }//? Nullable Property
        [DataType(DataType.Date)]
        public float? Salary { get; set; }
    }
}
