using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class ToolModel
    {
        public string toolName { get; set; }
        public double cuttingSpeed { get; set; }
        public double spindleSpeed { get; set; }
        public double diameter { get; set; }
        public double numberOfTeeth { get; set; }
        public double feed { get; set; }
        public double feedPerTooth { get; set; }
        public double feedPerRevolution { get; set; }

    }
}
