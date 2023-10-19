## Домашнее задание к Уроку 2. Интерфейсы и обобщения
1. Реализуйте операторы неявного приведения из long,int,byte в Bits
---
Решение.

Для решения задачи в классе Bits определены операторы неявного преобразования типов, в которых реализована логика преобразований типов из long,int,byte в Bits.

```
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

```

 В методе Main() класса Program продемонстрировано неявное преобразование типов из  long,int,byte в Bits.