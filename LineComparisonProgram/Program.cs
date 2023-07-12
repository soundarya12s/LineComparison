using System;

namespace LineComparisonProgram {
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Problem statement");
            Operation op1 = new Operation(0,2,0,4);
            double line1 = op1.CalculateLength();
            Operation op2 = new Operation(1, 2, 1, 4);
            double line2 = op2.CalculateLength();

            if (line1.Equals(line2))
                Console.WriteLine("Line1 and Line2 are equal");
            else
                Console.WriteLine("Line 1 and Line 2 are not equal");


            if ((line1.CompareTo(line2) == 0))
                Console.WriteLine("Both are equal");
            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line1>line2");
            if (line1.CompareTo(line2) < 0))
                    Console.WriteLine("Line1< line2");s

        }
    }

}
