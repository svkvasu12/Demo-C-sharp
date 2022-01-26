using System;
using System.Collections.Generic;

#nullable disable

namespace reverse_Engineering_Database_first
{
    public partial class MotorCycle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
