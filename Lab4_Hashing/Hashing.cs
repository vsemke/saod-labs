namespace Lab4_Hashing
{
    /// <summary>
    /// Анализ хеш-функций по числу коллизий (метод цепочек).
    /// </summary>
    public static class HashAnalysis
    {
        /// <summary>
        /// Число коллизий при заполнении массива цепочек ключами:
        /// коллизия - ключ попадает в уже непустую цепочку.
        /// </summary>
        public static int CountCollisions(int[] keys, Func<int, int> hash)
        {
            List<int>[] chains = new List<int>[HashFunctions.AddressCount];
            int collisions = 0;
            foreach (int key in keys)
            {
                int address = hash(key);
                if (chains[address] == null)
                    chains[address] = new List<int>();
                else
                    collisions++;                   // цепочка уже не пуста
                chains[address].Add(key);
            }
            return collisions;
        }

        /// <summary>
        /// Сравнение функций хеширования. iterations раз:
        /// 1) массив M из 1000 случайных чисел 0..100000;
        /// 2) для каждой функции считается число коллизий k;
        /// 3) счетчик t лучшей функции (минимум коллизий) увеличивается на 1,
        ///    при равенстве - у всех функций с минимумом.
        /// Возвращает счетчики t для всех функций.
        /// </summary>
        public static int[] CompareFunctions(int iterations, Random rnd)
        {
            Func<int, int>[] functions = HashFunctions.All;
            int[] wins = new int[functions.Length];
            int[] m = new int[1000];
            int[] collisions = new int[functions.Length];

            for (int iter = 0; iter < iterations; iter++)
            {
                for (int i = 0; i < m.Length; i++)                  // 1. Случайные ключи
                    m[i] = rnd.Next(0, 100001);

                for (int f = 0; f < functions.Length; f++)          // 2. Коллизии каждой функции
                    collisions[f] = CountCollisions(m, functions[f]);

                int min = collisions.Min();                         // 3. Победитель (или несколько)
                for (int f = 0; f < functions.Length; f++)
                    if (collisions[f] == min)
                        wins[f]++;
            }
            return wins;
        }
    }

    /// <summary>
    /// Метод открытой адресации (МОА) с линейным пробированием.
    /// Пустая ячейка = 0, поэтому ключи должны быть больше 0.
    /// </summary>
    public class OpenAddressingTable
    {
        private readonly int[] cells;
        private readonly Func<int, int> hash;

        public OpenAddressingTable(int size, Func<int, int> hash)
        {
            cells = new int[size];
            this.hash = hash;
        }

        /// <summary>
        /// Вставка: позиция d = H(K); если занята - d+1, d+2, ... с переходом с конца на начало.
        /// Дубликаты не вставляются. Возвращает false, если ключ не вставлен.
        /// </summary>
        public bool Insert(int key)
        {
            int pos = hash(key);
            for (int step = 0; step < cells.Length; step++)
            {
                if (cells[pos] == 0)            // пустая ячейка - вставляем
                {
                    cells[pos] = key;
                    return true;
                }
                if (cells[pos] == key)          // такой ключ уже есть
                    return false;
                if (++pos == cells.Length)      // следующая ячейка, с конца - на начало
                    pos = 0;
            }
            return false;                       // таблица заполнена
        }

        /// <summary>
        /// Поиск: просмотр с позиции H(K), пока не найден ключ, не встретилась пустая ячейка
        /// или не просмотрен весь массив. Каждое обращение к ячейке - одно сравнение.
        /// </summary>
        public bool Search(int key, ref long comparisons)
        {
            int[] a = cells;
            int pos = hash(key);
            for (int step = 1; step <= a.Length; step++)
            {
                int cell = a[pos];
                if (cell == key || cell == 0)       // найден ключ или пустая ячейка
                {
                    comparisons += step;            // step - число просмотренных ячеек
                    return cell == key;
                }
                if (++pos == a.Length)              // следующая ячейка, с конца - на начало
                    pos = 0;
            }
            comparisons += a.Length;                // просмотрен весь массив
            return false;
        }

        /// <summary>Поиск всех ключей. Возвращает число найденных, comparisons - общее число сравнений.</summary>
        public int SearchAll(int[] keys, out long comparisons)
        {
            comparisons = 0;
            int found = 0;
            foreach (int key in keys)
                if (Search(key, ref comparisons))
                    found++;
            return found;
        }
    }

    /// <summary>
    /// Метод цепочек (МС): массив списков, ключи с одинаковым адресом хранятся в одной цепочке.
    /// </summary>
    public class ChainedTable
    {
        private readonly List<int>[] chains;
        private readonly Func<int, int> hash;

        public ChainedTable(int size, Func<int, int> hash)
        {
            chains = new List<int>[size];
            for (int i = 0; i < size; i++)
                chains[i] = new List<int>();
            this.hash = hash;
        }

        /// <summary>Вставка в цепочку H(K). Дубликаты не вставляются.</summary>
        public bool Insert(int key)
        {
            List<int> chain = chains[hash(key)];
            if (chain.Contains(key))
                return false;
            chain.Add(key);
            return true;
        }

        /// <summary>Поиск: сравнения с элементами одной цепочки.</summary>
        public bool Search(int key, ref long comparisons)
        {
            List<int> chain = chains[hash(key)];
            for (int i = 0; i < chain.Count; i++)
            {
                comparisons++;
                if (chain[i] == key)
                    return true;
            }
            return false;
        }

        /// <summary>Поиск всех ключей. Возвращает число найденных, comparisons - общее число сравнений.</summary>
        public int SearchAll(int[] keys, out long comparisons)
        {
            comparisons = 0;
            int found = 0;
            foreach (int key in keys)
                if (Search(key, ref comparisons))
                    found++;
            return found;
        }
    }
}
