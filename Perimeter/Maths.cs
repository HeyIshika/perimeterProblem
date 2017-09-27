using System;

namespace Perimeter{
   
    public class math{

        TrianglePerimeter t1=new TrianglePerimeter();
        RectanglePerimeter r1=new RectanglePerimeter();
        SquarePerimeter S1 =new SquarePerimeter();

        public math(int side1 ,int side2 ,int bas){

          t1.s1=side1;
          t1.s2=side2;
          t1.b=bas;



        }
        public math(int length , int breadth){

            r1.l=length;
            r1.b=breadth;

        }
        public math(int side){

            S1.s=side;

        }

        public int CalculatePerimeter(int s1, int s2 ,int b){
            return s1+s2+b;
        }
         public int CalculatePerimeter( int l ,int b){
            return 2*(l+b);
        }
         public int CalculatePerimeter(int s){
            return 4*s;
        }

   }

}
  

      





