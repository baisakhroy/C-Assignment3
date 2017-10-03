using System;

namespace C_Assignment3{
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
}
   