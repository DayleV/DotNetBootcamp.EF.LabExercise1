using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkScheduleSolution.Entities
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string Description { get; set; }
        public bool RequiresTicket { get; set; }

        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }

    }
}
