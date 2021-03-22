using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KalkulatorCnc.Models
{
    public class DisplayToolModel
    {
        [Required]
        [StringLength(15, ErrorMessage ="Nazwa jest zbyt długa.")]
        [MinLength(3, ErrorMessage ="Nazwa jest zbyt krótka.")]
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
