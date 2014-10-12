using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    public abstract class Shape
    {
        //Skapar variablerna till basklassen
        private double _length;
        private double _width;
        //Egenskaperna till klassen
        public abstract double Area
        {
            get;
        }
        //Läser in längden och kontrollerar att värdet inte är under noll
        public double Length 
        {
            get { return _length; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }  
            
        }
        public abstract double Perimeter
        {
            get;
        }
        //Läser in bredden och kontrollerar att värdet inte är under noll
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }

        }
        //Skapar proteced konstruktor som kontrollerar som ansvarar för fälten
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }        
        //Metod som returnerar värdet på figuren
        public override string ToString()
        {
            return string.Format("Längd : {0,5} \nBredd : {1,5] \nOmkretts : {2,5} \nArea : {3,5}", Length, Width, Perimeter, Area);
            
        }
       
    }
        enum ShapeType 
        { 
            Ellipse, Rectangle
        }
}
