namespace Lab3_BinarySearch
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random();

        // Упорядоченный массив; выделен на 1 элемент больше - место под барьер последовательного поиска
        private int[] m;
        private int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Массив на 50 млн элементов генерируется несколько секунд, поэтому сначала
            // показываем форму, а генерацию запускаем сразу после ее отображения
            BeginInvoke(new Action(() =>
            {
                Refresh();
                GenerateArray();
            }));
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateArray();
        }

        // Заполнение массива датчиком случайных чисел и сортировка по возрастанию
        private void GenerateArray()
        {
            Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Генерация массива...";
            lblStatus.Refresh();
            try
            {
                n = (int)nudSize.Value;

                // Освобождаем память старого массива перед выделением нового
                m = null;
                GC.Collect();

                m = new int[n + 1];
                for (int i = 0; i < n; i++)
                    m[i] = rnd.Next(0, n);
                Array.Sort(m, 0, n);   // ячейка барьера m[n] в сортировке не участвует

                ClearResults();
                lblStatus.Text = $"Массив из {n:N0} элементов, значения 0..{n - 1:N0}. " +
                                 $"Для неудачного поиска введите ключ не меньше {n:N0}.";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ClearResults()
        {
            foreach (TextBox box in new[] { txtTimeA, txtIndexA, txtTimeB, txtIndexB, txtTimeC, txtIndexC,
                                            txtTimeD, txtIndexD, txtTimeSeq, txtIndexSeq })
                box.Text = "";
            lblSeqMeasured.Text = "";
        }

        // Кнопка «Найти»: все пять алгоритмов с одним и тем же ключом
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (m == null)
                return;
            int key = (int)nudKey.Value;
            int binRepeats = (int)nudBinRepeats.Value;
            int seqRepeats = (int)nudSeqRepeats.Value;
            int index;

            Cursor = Cursors.WaitCursor;
            try
            {
                txtTimeA.Text = MeasureTime(() => Algorithms.BinarySearchA(m, n, key), binRepeats, out index).ToString();
                txtIndexA.Text = IndexToText(index);

                txtTimeB.Text = MeasureTime(() => Algorithms.BinarySearchB(m, n, key), binRepeats, out index).ToString();
                txtIndexB.Text = IndexToText(index);

                txtTimeC.Text = MeasureTime(() => Algorithms.InterpolationSearch(m, n, key), binRepeats, out index).ToString();
                txtIndexC.Text = IndexToText(index);

                txtTimeD.Text = MeasureTime(() => Algorithms.JumpSearch(m, n, key), binRepeats, out index).ToString();
                txtIndexD.Text = IndexToText(index);
                Refresh();

                // Последовательный поиск очень медленный, поэтому повторяется меньшее число раз,
                // а время пересчитывается на число повторов бинарного поиска
                int seqTime = MeasureTime(() => Algorithms.SequentialSearch(m, n, key), seqRepeats, out index);
                long recalculated = (long)seqTime * binRepeats / seqRepeats;
                txtTimeSeq.Text = recalculated.ToString();
                txtIndexSeq.Text = IndexToText(index);
                lblSeqMeasured.Text = $"Измерено {seqTime} тиков за {seqRepeats} повторов, × {binRepeats} / {seqRepeats}";
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
        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (m != null)
                nudKey.Value = m[rnd.Next(0, n)];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
