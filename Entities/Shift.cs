using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }
        public int PlacementContractID { get; set; }
        public int DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        public string? Notes { get; set; }

        public PlacementContract PlacementContract { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
