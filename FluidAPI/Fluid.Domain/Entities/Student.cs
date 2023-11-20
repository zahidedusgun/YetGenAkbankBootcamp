using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluid.Domain.Enums;

namespace Fluid.Domain.Entities
{
    public class Student : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public bool IsGraduated { get; set; }
        public int Age { get; set; }
        public decimal RegistrationPrice { get; set; }
        public Gender Gender { get; set; }
    }
}
