namespace Lab4_Hashing
{
    /// <summary>
    /// Хеш-функции. Хеш-адрес в диапазоне 0..999 (1000 адресов).
    /// Ключ в строку не переводится - только арифметика с числами.
    /// </summary>
    public static class HashFunctions
    {
        public const int AddressCount = 1000;

        /// <summary>Названия функций (в том же порядке, что и в <see cref="All"/>).</summary>
        public static readonly string[] Names =
        {
            "Метод деления",
            "Метод середины квадрата",
            "Метод свертывания",
            "Метод умножения",
        };

        /// <summary>Все четыре функции: 0 - деление, 1 - середина квадрата, 2 - свертывание, 3 - умножение.</summary>
        public static readonly Func<int, int>[] All = { Division, MidSquare, Folding, Multiplication };

        /// <summary>
        /// Метод деления: H(K) = K mod 997 (997 - простое число, ближайшее к 1000).
        /// </summary>
        public static int Division(int key)
        {
            return key % 997;
        }

        /// <summary>
        /// Метод середины квадрата: ключ возводится в квадрат,
        /// из середины результата берутся три цифры.
        /// </summary>
        public static int MidSquare(int key)
        {
            long square = (long)key * key;          // 1. S = K^2 (long, чтобы не было переполнения)
            if (square < AddressCount)              // 2. Меньше трех цифр - это и есть адрес
                return (int)square;

            int digits = 0;                         // 3. Количество цифр S (делением на 10)
            for (long s = square; s > 0; s /= 10)
                digits++;

            int start = (digits - 3) / 2;           // 4. Сколько младших цифр отбросить
            long divisor = 1;
            for (int i = 0; i < start; i++)
                divisor *= 10;

            return (int)(square / divisor % 1000);  // 5. Три цифры из середины
        }

        /// <summary>
        /// Метод свертывания: ключ делится справа налево на части по 3 цифры,
        /// части складываются, перенос в старший разряд игнорируется.
        /// </summary>
        public static int Folding(int key)
        {
            long sum = 0;
            for (long k = key; k > 0; k /= 1000)    // части по 3 цифры справа налево
                sum += k % 1000;
            return (int)(sum % 1000);               // перенос в старший разряд отбрасывается
        }

        // Константа Кнута для метода умножения: A = (sqrt(5) - 1) / 2 ≈ 0,6180339887
        private static readonly double GoldenRatio = (Math.Sqrt(5) - 1) / 2;

        /// <summary>
        /// Метод умножения: H(K) = floor(1000 · D(K·A)), где D - дробная часть.
        /// </summary>
        public static int Multiplication(int key)
        {
            double product = key * GoldenRatio;                 // 1. K·A
            double fraction = product - Math.Floor(product);    // 2. Дробная часть
            int address = (int)(AddressCount * fraction);       // 3. Умножить на число адресов и отбросить дробь
            return Math.Min(address, AddressCount - 1);         // защита от погрешности округления
        }
    }
}
