using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reverse
            int[] reverseTestData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Demonstration av Reverse:");
            Console.WriteLine("Före: " + string.Join(",", reverseTestData));
            Reverse(reverseTestData);
            Console.WriteLine("Efter: " + string.Join(",", reverseTestData));
        }

        public static void Reverse(int[] numbers)
        {
            int[] numbers2 = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers2[numbers.Length - i - 1];
            }
        }
    }
}
