﻿namespace Bits
{

    class Bits : IBits
    {
        public Bits(byte b)
        {
            this.Value = b;
            this.Size = 8;
        }

        public Bits(short b)
        {
            this.Value = b;
            this.Size = 16;
        }

        public Bits(int b)
        {
            this.Value = b;
            this.Size = 32;
        }

        public Bits(long b)
        {
            this.Value = b;
            this.Size = 64;
        }

        public long Value { get; private set; } = 0;
        private int Size = 64;

        public static implicit operator Bits(long b) 
        {
            return new Bits(b);
        }

        public static implicit operator Bits(int b) 
        {
            return new Bits(b); 
        }

        public static implicit operator Bits(byte b) 
        {
            return new Bits(b); 
        }

        public bool getBits(int numer)
        {
            if (numer > Size - 1 || numer < 0)
            {
                Console.WriteLine("Ошибка! Выход за пределы");
                return false;
            }
            return ((Value >> numer) & 1) == 1;
        }

        public void setBits(int numer, bool bit)
        {
            if (numer > Size - 1 || numer < 0) return;
            if (bit == true)
                Value = (byte)(Value | (1 << numer));
            else
            {
                var mask = (byte)(1 << numer);
                mask = (byte)(0xff ^ mask);
                Value &= (byte)(Value & mask);
            }
        }
    }
}
