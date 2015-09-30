using System;
class BitsExchange
{
    static void Main()
    {
        Console.Write("Input n: ");
        uint n = uint.Parse(Console.ReadLine());
        uint firstBits = (n >> 3) & 5;
        uint secondBits = (n >> 24) & 5;
        uint mask1 = 7 << 3;
        uint mask2 = 7 << 24;
        n = n & ~mask1 | (secondBits << 3);
        n = n & ~mask2 | (firstBits << 24);
        Console.WriteLine("Result: {0}", n);
    }
}