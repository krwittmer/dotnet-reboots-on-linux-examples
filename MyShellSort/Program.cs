using System;

namespace ConsoleApplication
{
    public class Program
    {
        static bool ShortComparer(short a, short b) => a > b;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Preparing to sort data.");
            short[] data = {10,7,3,1,9,7,4,3}; 
            ShellSorter.Sort<short>(data, ShortComparer);
            Console.WriteLine("Finished sorting data. The array contents are: ");
            Console.WriteLine(string.Join(",", data));
        }
    }
}
