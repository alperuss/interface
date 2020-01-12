using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkDeneme.Models
{
    public class CustomerDemographic
    {
        [Key]
        [Required, MaxLength(10)]
        public string CustomerTypeId { get; set; }

        public string CustomerDesc { get; set; }

        public CustomerCustomerDemo CustomerCustomerDemo { get; set; }

    }
}
