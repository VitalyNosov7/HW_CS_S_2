namespace Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeLine = 100;

            long    longToBits     = 100000000;
            int     intToBits      = 10;
            byte    byteToBits     = 50;

            Bits bitsGetsLong   = longToBits;
            Bits bitsGetsInt    = intToBits;
            Bits bitsGetsByte   = byteToBits;

            Console.WriteLine("Неявное приведение типов из long,int,byte в Bits:");

            Console.WriteLine(new string('=', sizeLine));

            Console.WriteLine(  $"Переменная longToBits, типа long ({longToBits.GetType()}," +
                                $" значение {longToBits}) неявно приведена к типу Bits - переменная bitsGetsLong" +
                                $"  ({bitsGetsLong.GetType()}, значение {bitsGetsLong.Value})");

            Console.WriteLine(new string('=', sizeLine));

            Console.WriteLine($"Переменная intToBits, типа int ({intToBits.GetType()}," +
                                $" значение {intToBits}) неявно приведена к типу Bits - переменная bitsGetsInt" +
                                $"  ({bitsGetsInt.GetType()}, значение {bitsGetsInt.Value})");

            Console.WriteLine(new string('=', sizeLine));

            Console.WriteLine($"Переменная byteToBits, типа byte ({byteToBits.GetType()}," +
                                $" значение {byteToBits}) неявно приведена к типу Bits - переменная bitsGetsByte" +
                                $"  ({bitsGetsByte.GetType()}, значение {bitsGetsByte.Value})");
            Console.WriteLine(new string('=', sizeLine));

            Console.ReadLine();
        }
    }
}