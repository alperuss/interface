using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkDeneme.Models
{
    public class EmployeeTerritory
    {
        [Key]
        [Required, MaxLength(20)]
        public string TerritoryId { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Territory Territory { get; set; }
    }
}
