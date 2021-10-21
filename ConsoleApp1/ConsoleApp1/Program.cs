using System;

namespace ConsoleApp1
{
    class Program
    {
      
        public static double lineLength(double x1,double y1, double x2,double y2)
        {

            double LengthOfLine = Math.Sqrt((x2 - x1) + (y2 - y1));
            Console.WriteLine(LengthOfLine + "length of line ");
            return LengthOfLine;
        }
        public static void compare(double line1, double line2)
        {
            if (line1 == line2)
            {
                Console.WriteLine("Both Lines are equal");
            }
            else if(line1 > line2)
            {
                Console.WriteLine("line1greater than line2");

            }
            else if (line1 < line2)
            {
                Console.WriteLine("line1 lss than line2");
            }
            else
            {
                Console.WriteLine("There is the error");
            }
            





        }

        static void Main(string[] args)
        {
            Console.WriteLine("Well Come to Line Comparision Computation program on master branch");
            double line1 = lineLength(10, 5, 15, 10);
            double line2 = lineLength(20, 10, 30, 20);
            compare(line1,line2);

        }
    }
}
