using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    public class Ellipse:Shape
    {
        //Skapar egenskaperna som räknar ut Area och omkrets
        public override double Area
        {            
            get 
            {
                double a = Length / 2;
                double b = Width / 2;
                return Math.PI * a * b;
            }            
        }
        public override double Perimeter 
        {
            get 
            {   
                double a = Length / 2;
                double b = Width / 2;
                return Math.PI * Math.Sqrt(2 * a * a + 2 * b * b);
            }
        }
        //Skapar konstruktorn som ärver ifrån basklassen
        public Ellipse( double lenght, double width) : base(lenght, width)
        {

        }
    }
}
