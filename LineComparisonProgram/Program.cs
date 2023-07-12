using System;

namespace LineComparisonProgram {
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Problem statement");
            Operation op = new Operation(0,2,0,4);
            op.CalculateLength();
        }
    }

}
