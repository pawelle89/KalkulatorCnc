using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalkulatorCnc
{
    public class Calc : ComponentBase
    {
        public double cuttingSpeed { get; set; }
        public double spindleSpeed { get; set; }
        public double diameter { get; set; }
        public double numberOfTeeth { get; set; }
        public double feed { get; set; }
        public double feedPerTooth { get; set; }
       
        public void SpindleSpeed()
        {
            spindleSpeed = cuttingSpeed / Math.PI / diameter * 1000;
            spindleSpeed = Math.Round(spindleSpeed, 0);
        }
        public void CuttingSpeed()
        {
            cuttingSpeed = Math.PI * diameter * spindleSpeed / 1000;
            cuttingSpeed = Math.Round(cuttingSpeed, 0);
        }
        public void Diameter()
        {
            diameter = (cuttingSpeed * 1000) / (Math.PI * spindleSpeed);
            diameter = Math.Round(diameter, 1);
        }
        public void Feed()
        {
            feed = feedPerTooth * numberOfTeeth * spindleSpeed;
            feed = Math.Round(feed, 1);
        }
    }
}
