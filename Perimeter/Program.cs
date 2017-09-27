using System;

namespace Perimeter
{   
  
  class Program
    {
        static void Main()
        {   begin:
            Console.WriteLine("Enter your choice for perimeter Calculation");
            Console.WriteLine("Enter [1] for triangle perimeter Calculation");
            Console.WriteLine("Enter [2] for rectangle perimeter Calculation");
            Console.WriteLine("Enter [3] for square perimeter Calculation");
            int choice=int.Parse(Console.ReadLine());

            switch(choice){

                case 1:  Console.WriteLine("Enter parameters for Calculation of perimeter of Triangle");
                         int s1=int.Parse(Console.ReadLine());
                         int s2=int.Parse(Console.ReadLine());
                         int b=int.Parse(Console.ReadLine());
                         math g=new math(s1,s2,b);
                         int result=g.CalculatePerimeter(s1,s2,b);
                         Console.WriteLine("The perimeter is {0}" , result);
                         break;


                         

                      
                case 2:Console.WriteLine("Enter parameters for Calculation of perimeter of Rectangle");
                         int length=int.Parse(Console.ReadLine());
                         int breadth=int.Parse(Console.ReadLine());
                         math g1=new math(length,breadth);
                         int result1=g1.CalculatePerimeter(length,breadth);
                         Console.WriteLine("The perimeter is {0}" , result1);
                         break;


                case 3:Console.WriteLine("Enter parameters for Calculation of perimeter of Rectangle");
                         int side=int.Parse(Console.ReadLine());
                         math g2=new math(side);
                         int result2=g2.CalculatePerimeter(side);
                         Console.WriteLine("The perimeter is {0}" , result2);
                         break;


                default:Console.WriteLine("You Entered wrong Choice");
                        break;
            }

            Console.WriteLine("Do you want to continue?-yes or no");
            string Choice=Console.ReadLine();

            switch(Choice.ToUpper()){

                case "YES":goto begin;

                case "NO" :break;

                default: Console.WriteLine("you typed something gibberish");
                        break;
                           
            }

            
        }
    }
}
