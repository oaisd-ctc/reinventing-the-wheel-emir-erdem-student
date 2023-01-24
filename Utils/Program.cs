using System;
using ArrayUtilities;
// using StringUtilities;
using MathUtilities;


namespace MyUtilities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] example = { 2, 3, 7, 14, 192, 21 };
            int[] newArray = ArrayUtils.Reverse(example);
            int[] newestArray = new int[example.Length];

            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }
 

        }

    }
}
