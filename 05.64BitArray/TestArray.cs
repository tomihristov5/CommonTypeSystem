// Problem 5. 64 Bit array
// Define a class BitArray64 to hold 64 bit values inside an ulong value.
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace _05._64BitArray
{
    using System;

    public static class TestArray
    {
        public static void Main()
        {
            Console.Write("Enter a ulong value: ");
            var array = new BitArray64(ulong.Parse(Console.ReadLine()));

            Console.WriteLine("Number in binary:");
            foreach (var bit in array)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine("Hashcode: " + array.GetHashCode());

            Console.Write("Enter the number of the index in the array(bit) to change: ");
            int index = int.Parse(Console.ReadLine());
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }

            Console.Write("Enter 0 or 1 for the value of the bit: ");
            int newBit = int.Parse(Console.ReadLine());
            array[index] = newBit;

            Console.WriteLine("With changed bit");
            foreach (var bit in array)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            Console.WriteLine("Hashcode: " + array.GetHashCode());
        }
    }
}
