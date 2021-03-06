using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class ToolModel
    {
        public string ToolName { get; set; }
        public double Diameter { get; set; }
        public double CuttingSpeed { get; set; }
        public double SpindleSpeed { get; set; }
        public double NumberOfTeeth { get; set; }
        public double Feed { get; set; }
        public double FeedPerTooth { get; set; }
        public double FeedPerRevolution { get; set; }

    }
}
