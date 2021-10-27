using System;

namespace ConsoleApp1
{
    class Program
    {
      
        public static double lineLength(double x1,double y1, double x2,double y2)
        {

            double LengthOfLine = Math.Sqrt(((x2 - x1)*(x2-x1)) + ((y2 - y1)*(y2-y1)));
            Console.WriteLine(LengthOfLine);
            return LengthOfLine;
        }
        public static void compare(double line1, double line2)
        {
            if (line1 == line2)
            {
                Console.WriteLine("Both Lines are equal");
            }
            else
            {
                Console.WriteLine("Both Lines are not equal");

            }
            





        }

        static void Main(string[] args)
        {
            Console.WriteLine("Well Come to Line Comparision Computation program on master branch");
            double line1=lineLength(10, 5, 15, 5);
            double line2=lineLength(10, 5, 15, 5);
            compare(line1,line2);

        }
    }
}
