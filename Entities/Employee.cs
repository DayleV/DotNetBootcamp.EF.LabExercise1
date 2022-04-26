using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkScheduleSolution.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char HomePhone { get; set; }
        public bool Active { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
