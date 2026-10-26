namespace Lab2_SequentialSearch
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random();

        // Массивы выделены на 1 элемент больше: последняя ячейка - место под барьер
        private int[] unsorted;
        private int[] sorted;
        private int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateArrays();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateArrays();
        }

        // Заполнение массивов датчиком случайных чисел
        private void GenerateArrays()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                n = (int)nudSize.Value;

                // Освобождаем память старых массивов перед выделением новых
                unsorted = null;
                sorted = null;
                GC.Collect();

                // Неупорядоченный массив
                unsorted = new int[n + 1];
                for (int i = 0; i < n; i++)
                    unsorted[i] = rnd.Next(0, n);

                // Упорядоченный массив: отдельные случайные числа + сортировка
                // (ячейка барьера sorted[n] в сортировке не участвует)
                sorted = new int[n + 1];
                for (int i = 0; i < n; i++)
                    sorted[i] = rnd.Next(0, n);
                Array.Sort(sorted, 0, n);

                ClearResults();
                lblStatus.Text = $"Массивы из {n:N0} элементов, значения 0..{n - 1:N0}. " +
                                 $"Для неудачного поиска введите ключ не меньше {n:N0}.";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ClearResults()
        {
            foreach (TextBox box in new[] { txtTimeAU, txtIndexAU, txtTimeBU, txtIndexBU,
                                            txtTimeBS, txtIndexBS, txtTimeCS, txtIndexCS })
                box.Text = "";
        }

        // Поиск в неупорядоченном массиве: алгоритмы A и B
        private void btnFindU_Click(object sender, EventArgs e)
        {
            int key = (int)nudKeyU.Value;
            int repeats = (int)nudRepeats.Value;
            int index;
            Cursor = Cursors.WaitCursor;
            try
            {
                txtTimeAU.Text = MeasureTime(() => Algorithms.SearchA(unsorted, n, key), repeats, out index).ToString();
                txtIndexAU.Text = IndexToText(index);

                txtTimeBU.Text = MeasureTime(() => Algorithms.SearchB(unsorted, n, key), repeats, out index).ToString();
                txtIndexBU.Text = IndexToText(index);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Поиск в упорядоченном массиве: алгоритм B (как в неупорядоченном) и алгоритм C
        private void btnFindS_Click(object sender, EventArgs e)
        {
            int key = (int)nudKeyS.Value;
            int repeats = (int)nudRepeats.Value;
            int index;
            Cursor = Cursors.WaitCursor;
            try
            {
                txtTimeBS.Text = MeasureTime(() => Algorithms.SearchB(sorted, n, key), repeats, out index).ToString();
                txtIndexBS.Text = IndexToText(index);

                txtTimeCS.Text = MeasureTime(() => Algorithms.SearchC(sorted, n, key), repeats, out index).ToString();
                txtIndexCS.Text = IndexToText(index);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Время (в тиках) выполнения поиска, повторенного repeats раз
        private static int MeasureTime(Func<int> search, int repeats, out int index)
        {
            index = -1;
            int start = Environment.TickCount;
            for (int r = 0; r < repeats; r++)
                index = search();
            int time = Environment.TickCount - start;
            return time;
        }

        private static string IndexToText(int index)
        {
            return index >= 0 ? index.ToString() : "Нет";
        }

        // Ключ = значение случайного элемента массива (для демонстрации удачного поиска)
        private void btnRandomU_Click(object sender, EventArgs e)
        {
            nudKeyU.Value = unsorted[rnd.Next(0, n)];
        }

        private void btnRandomS_Click(object sender, EventArgs e)
        {
            nudKeyS.Value = sorted[rnd.Next(0, n)];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
