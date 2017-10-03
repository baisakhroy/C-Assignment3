using System;

namespace C_Assignment3
{
    class Program
    {
        static void Main()
       {    float a; float side1,side2,b; float pt,pr,ps;
       start:
            Console.WriteLine("Make your Choice");
            Console.WriteLine("1.TrianglePerimeter \n2.RectanglePerimeter \n3.SquarePerimeter"); 
            a=float.Parse(Console.ReadLine());
            switch(a){
                case 1:
                Console.WriteLine("Input the length of the first side of your triangle");
                side1= float.Parse(Console.ReadLine());
                Console.WriteLine("Input the length of the second side of your triangle");
                side2= float.Parse(Console.ReadLine());
                Console.WriteLine("Input the length of the base of your triangle");
                b= float.Parse(Console.ReadLine());
                Math Triangle =new Math(side1,side2,b);
                pt=Triangle.CalculatePerimeter(side1,side2,b);
                break;
                case 2:
                Console.WriteLine("Input the values of the first side of your rectangle");
                side1= float.Parse(Console.ReadLine());
                Console.WriteLine("Input the values of the second side of your rectangle");
                side2= float.Parse(Console.ReadLine());
                Math Rectangle =new Math(side1,side2);
                pr=Rectangle.CalculatePerimeter(side1,side2);
                break;
                case 3:
                Console.WriteLine("Input the value of the side of your square");
                side1= float.Parse(Console.ReadLine());
                Math Square =new Math(side1);
                ps=Square.CalculatePerimeter(side1);
                break;
                default: Console.WriteLine("Your input is Invalid. Please make a proper choice");
                goto start;
                
            }     
       }
    }
}
    
