using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkScheduleSolution.Entities
{
    public class EmployeeSkill
    {
        [Key]
        public int EmployeeSkillID { get; set; }
        public int EmployeeID { get; set; }
        public int SkillID { get; set; }
        public int Level { get; set; }
        public int? YearsOFExperience { get; set; }
        public decimal HourlyWage { get; set; }
        public Employee Employee { get; set; }
        public Skill Skill { get; set; }
    }
}
