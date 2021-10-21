using System;

namespace ConsoleApp1
{
    class Program
    {
      
        public static double lineLength(int x1,int y1, int x2,int y2)
        {

            double LengthOfLine = Math.Sqrt((x2 - x1) + (y2 - y1));
            Console.WriteLine(LengthOfLine);
            return LengthOfLine;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Well Come to Line Comparision Computation program on master branch");
            lineLength(10, 5, 15, 5);     
        }
    }
}
