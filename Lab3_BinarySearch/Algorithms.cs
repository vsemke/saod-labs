namespace Lab3_BinarySearch
{
    /// <summary>
    /// Алгоритмы поиска в упорядоченном по возрастанию массиве m из n элементов.
    /// Массив выделен на 1 элемент больше: m[n] - место под барьер последовательного поиска.
    /// Индексы с 0. Результат - индекс найденного элемента или -1.
    /// </summary>
    public static class Algorithms
    {
        /// <summary>
        /// Алгоритм A. Неоптимальный бинарный поиск (проверка на равенство в цикле).
        /// </summary>
        public static int BinarySearchA(int[] m, int n, int key)
        {
            int left = 0, right = n - 1;           // A1. Границы L и R
            while (left <= right)                  // A2. Пока интервал не пуст
            {
                int i = (left + right) / 2;        // A3. Середина (n <= 100 млн, переполнения нет)
                if (key == m[i])                   // A4. Найдено
                    return i;
                if (key < m[i])                    // A5. Ключ в левой половине
                    right = i - 1;
                else                               // A6. Ключ в правой половине
                    left = i + 1;
            }
            return -1;
        }

        /// <summary>
        /// Алгоритм B. Оптимальный бинарный поиск (Вирт): в цикле нет проверки на равенство,
        /// интервал сужается до одного элемента, затем одно сравнение.
        /// При дубликатах находит первое вхождение.
        /// </summary>
        public static int BinarySearchB(int[] m, int n, int key)
        {
            if (n == 0)
                return -1;
            int left = 0, right = n - 1;           // B1. Границы L и R
            while (left < right)                   // B2. Пока в интервале больше одного элемента
            {
                int i = (left + right) / 2;        // B3. Середина
                if (key <= m[i])                   // B4. Ключ в левой половине (включая i)
                    right = i;
                else                               // B5. Ключ в правой половине
                    left = i + 1;
            }
            return m[right] == key ? right : -1;   // B6. Единственная проверка на равенство
        }

        /// <summary>
        /// Алгоритм C. Интерполяционный поиск: позиция i оценивается по значению ключа
        /// (как поиск слова в словаре). Промежуточные вычисления в long.
        /// </summary>
        public static int InterpolationSearch(int[] m, int n, int key)
        {
            int left = 0, right = n - 1;                           // C1. Границы L и R
            // C2. Пока ключ строго внутри (M[L], M[R]); L <= R защищает от выхода за границы
            while (left <= right && m[left] < key && key < m[right])
            {
                // C3. Оценка позиции: i = L + (K - M[L]) * (R - L) / (M[R] - M[L])
                int i = (int)(left + ((long)key - m[left]) * (right - left) / ((long)m[right] - m[left]));
                if (key == m[i])                                   // C4. Найдено
                    return i;
                if (key < m[i])                                    // C5. Ключ левее i
                    right = i - 1;
                else                                               // C6. Ключ правее i
                    left = i + 1;
            }
            // C7. Ключ может совпасть с границей интервала
            if (left <= right)
            {
                if (key == m[left])
                    return left;
                if (key == m[right])
                    return right;
            }
            return -1;
        }

        /// <summary>
        /// Алгоритм D. «Последовательный» бинарный поиск: движение вперед прыжками,
        /// длина прыжка B уменьшается вдвое. P - последний элемент меньше ключа
        /// (или 0, если таких нет).
        /// </summary>
        public static int JumpSearch(int[] m, int n, int key)
        {
            if (n == 0)
                return -1;
            int p = 0, b = n / 2;                          // D1. Начальная позиция и длина прыжка
            while (b > 0)                                  // D2. Пока длина прыжка не нулевая
            {
                while (p + b < n && m[p + b] < key)        // D3. Прыгаем вперед, пока элемент меньше ключа
                    p += b;
                b /= 2;                                    // D4. Уменьшаем прыжок вдвое
            }
            if (m[p] == key)                               // D5. Ключ в позиции P (бывает, когда P = 0)
                return p;
            if (p + 1 < n && m[p + 1] == key)              // D6. Ключ - следующий за P элемент
                return p + 1;
            return -1;
        }

        /// <summary>
        /// Последовательный поиск в упорядоченном массиве с барьером K + 1
        /// (алгоритм C из ЛР2). Требуется m.Length &gt; n и key &lt; int.MaxValue.
        /// </summary>
        public static int SequentialSearch(int[] m, int n, int key)
        {
            m[n] = key + 1;                                // Барьер больше ключа
            int i = 0;
            while (key > m[i])                             // Пока элементы меньше ключа
                i++;
            return (i < n && m[i] == key) ? i : -1;
        }
    }
}
