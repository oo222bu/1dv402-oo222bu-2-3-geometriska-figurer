using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    public class Rectangle:Shape
    {
        //Räknar ut Area
        public override double Area 
        {
            get 
            {
                return Length * Width;
            }
        }
 
        //Räknar ut Omkretsen
        public override double Perimeter 
        {
            get 
            {
                return (2 * Length) + (2 * Width);
            }
        }
   
        //Konstruktorn man ärver ifrån shape klassen
        public Rectangle(double length, double width):base(length, width)
        {

        }
    }
}
