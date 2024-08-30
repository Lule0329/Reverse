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
            // två värden som börjar på olika sidor av arrayen
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                // Byter plats på talen i arrayen
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;

                // Flyttar höger ett steg neråt och flyttar vänster ett steg uppåt
                left++;
                right--;
            }
        }
    }
}
