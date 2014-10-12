using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {                
                Console.Clear();
                ViewMenu();
                try
                {
                    int menu = int.Parse(Console.ReadLine());
                    if (menu < 0 || menu > 2)
                    {
                        throw new ArgumentException();
                    }


                    switch (menu)
                    {
                        case 0: Console.WriteLine();
                            return;
                        case 1: ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                            break;
                        case 2: ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFel! Ange ett nummer mellan [0-2]");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n Tryck tangent för att fortsätta");
                    Console.ResetColor();
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==============================================================");
            switch (shapeType)
	        {
		        case ShapeType.Ellipse:Console.WriteLine("=                        Ellipse                             =");
                break;
                case ShapeType.Rectangle:Console.WriteLine("=                        Rectangle                           =");
                break;
	        }
            Console.WriteLine("==============================================================");
            Console.ResetColor();
            double length = ReadDoubleGreaterThanZero("\nAnge längd:");
            double width = ReadDoubleGreaterThanZero("Ange bredd:");
            if (shapeType == ShapeType.Rectangle)
            {
                Rectangle firstRectangle = new Rectangle(length, width);
                return firstRectangle;
            }
            else
            {
                Ellipse firstEllipse = new Ellipse(length, width);
                return firstEllipse;
            }
        }           
        //Statisk metod som ska visa en meny.
        private static void ViewMenu() 
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==============================================================");
            Console.WriteLine("=                                                            =");
            Console.WriteLine("=                  Geometriska Figurer                       =");
            Console.WriteLine("=                                                            =");
            Console.WriteLine("==============================================================");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("0. Avsluta.");
            Console.WriteLine("\n1. Ellips.");
            Console.WriteLine("\n2. Rectangel.");
            Console.WriteLine("\n==============================================================");
            Console.Write("\nAnge menyval [0-2]:");
        }
        //Statisk metod som presenterar figurens detaljer.
        private static void ViewShapeDetail(Shape shape) 
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n==============================================================");
            Console.WriteLine("=                        Detaljer                            =");
            Console.WriteLine("==============================================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("==============================================================");
        }
        //metod som ska returnera ett värde av typen double
        private static double ReadDoubleGreaterThanZero(string prompt) 
        {
            while (true)
            {
                Console.Write(prompt);              
                try
                {
                    string input = Console.ReadLine(); 
                    double value = double.Parse(input);
                    if (value <= 0)
                    {
                        throw new Exception();
                    }
                    return double.Parse(input);
                }
                catch 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Fel! ange ett flyttal större än 0. ");
                    Console.ResetColor();
                }               
            }
        }
    }
}
