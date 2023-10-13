## Домашнее задание к Уроку 2. Интерфейсы и обобщения
1. Реализуйте операторы неявного приведения из long,int,byte в Bits
---
Решение.

Для решения задачи в классе Bits созданы перегрузки операторов неявного преобразования типов, в которых должна быть реализована логика преобразований типов из long,int,byte в Bits.

```
        public static implicit operator long(Bits b)
        {
            return new long { };
        }

        public static implicit operator int(Bits b)
        {
            return new int { };
        }

        public static implicit operator byte(Bits b)
        {
            return new byte { };
        }

```

Реализовать логику преобразований типов из long,int,byte в Bits не удалось по причине отсутствия знаний, опыта и времени, чтобы более глубже разобраться с реализацией поставленной задачи.