using System;
using System.Collections.Generic;

#nullable disable

namespace reverse_Engineering_Database_first
{
    public partial class Company
    {
        public Company()
        {
            Cars = new HashSet<Car>();
            MotorCycles = new HashSet<MotorCycle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<MotorCycle> MotorCycles { get; set; }
    }
}
