using System;

namespace C_Assignment3
{


    public class TrianglePerimeter{
        public float side1 {get; set;}
        public float side2 {get;set;}
        public float b {get;set;}
    }
    public class RectanglePerimeter{
        public float side1 {get;set;}
        public float side2 {get;set;}
    }
    public class SquarePerimeter{
      public float side1 {get;set;}
    }
   public class Math{

       TrianglePerimeter T= new TrianglePerimeter();
       RectanglePerimeter R = new RectanglePerimeter();
       SquarePerimeter S = new SquarePerimeter();

       public Math( float a, float b, float c)
       {
           T.side1 = a;
           T.side2 =b;
           T.b =c;
       }
       public Math(float a, float b)
       {
           R.side1= a;
           R.side2 =b;
       }
        public Math(float a)
        {
            S.side1=a;
        }

        public float CalculatePerimeter(float a, float b,float c){
            a = T.side1;
            b = T.side2;
            c = T.b;
             Console.WriteLine("Perimeter of your triangle ={0}", a+b+c);
             return (a+b+c);
        }
public float CalculatePerimeter(float a, float b){
            a = R.side1;
            b = R.side2;
             Console.WriteLine("Perimeter of your rectangle ={0}", 2*(a+b));
             return (2*(a+b));
        }
        public float CalculatePerimeter(float a){
            a = S.side1;
             Console.WriteLine("Perimeter of your square ={0}", 4*(a));
             return (4*a);
        }


   }
   

    
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
                Console.WriteLine("Input the values of the sides and the base of your triangle");
                side1= float.Parse(Console.ReadLine());
                side2= float.Parse(Console.ReadLine());
                b= float.Parse(Console.ReadLine());
                Math Triangle =new Math(side1,side2,b);
                pt=Triangle.CalculatePerimeter(side1,side2,b);
                break;
                case 2:
                Console.WriteLine("Input the values of the sides of your rectangle");
                side1= float.Parse(Console.ReadLine());
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
    
