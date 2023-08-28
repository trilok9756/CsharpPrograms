using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labprogram
{
    internal class Class1
    {
        public static void main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 22, 9, 15 };
            int sum = 0;
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount += 1;
                }
                else
                {
                    oddCount += 1;
                }
            }
            System.Console.WriteLine("even Count:" + evenCount);

            System.Console.WriteLine("odd Count:" + oddCount);
        }
    }

}