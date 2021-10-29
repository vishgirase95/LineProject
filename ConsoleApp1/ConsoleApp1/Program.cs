using System;

namespace ConsoleApp1
{
    class Program
    {
      
        public static double lineLength(double x1,double y1, double x2,double y2, double a)
        {

            double LengthOfLine = Math.Sqrt((x2 - x1) + (y2 - y1));
            LengthOfLine = Math.Round(LengthOfLine, 2);
            Console.WriteLine(LengthOfLine + "   length of line " +a);
            return LengthOfLine;
        }
        public static void compare(double line1, double line2)
        {
            if (line1.CompareTo(line2)==0)
            {
                Console.WriteLine("Both Lines are equal");
            }
            else if(line1.CompareTo(line2)>0)
            {
                Console.WriteLine("line_1 greater than line_2");

            }
            else if (line1.CompareTo(line2)<0)
            {
                Console.WriteLine("line_1 is  less than line_2");
            }
            else
            {
                Console.WriteLine("There is the error");
            }
            





        }

        static void Main(string[] args)
        {
            Console.WriteLine("Well Come to Line Comparision Computation program on master branch");
            double line1 = lineLength(10, 5, 15, 10, 1);
            double line2 = lineLength(20, 10, 30, 20,2);
            compare(line1,line2);

        }
    }
}
