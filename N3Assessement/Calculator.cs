using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3Assessement
{
    
    public class Calculator
    {
        //create calculate method for area
        public double Calculate(double length, double width)
        {
            return length * width;
        }
        //create calculate method for volume
        public double Calculate(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
