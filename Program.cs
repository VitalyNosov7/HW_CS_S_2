namespace Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long    longToBits     = 100000000;
            int     intToBits      = 10;
            byte    byteToBits     = 10;

            Bits bitsGetsLong   = longToBits;
            Bits bitsGetsInt    = intToBits;
            Bits bitsGetsByte   = byteToBits;

            Console.ReadLine();
        }
    }
}