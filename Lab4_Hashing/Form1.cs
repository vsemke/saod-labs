namespace Lab4_Hashing
{
    public partial class Form1 : Form
    {
        private const int TestKey = 45678;
        private const int TableSize = 10000;     // размер массива МОА и число ключей в M1, M2

        private readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // До анализа для сравнения методов выбран метод деления
            cmbHashFunction.SelectedIndex = 0;
        }

        // ---------- Тест хеш-функций (отдельная область, в расчетах не участвует) ----------

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtTestDivision.Text = HashFunctions.Division(TestKey).ToString();
            txtTestMidSquare.Text = HashFunctions.MidSquare(TestKey).ToString();
            txtTestFolding.Text = HashFunctions.Folding(TestKey).ToString();
            txtTestMultiplication.Text = HashFunctions.Multiplication(TestKey).ToString();
        }

        // ---------- Сравнение функций хеширования ----------

        private void btnRun_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                int[] wins = HashAnalysis.CompareFunctions((int)nudIterations.Value, rnd);

                txtWinsDivision.Text = wins[0].ToString();
                txtWinsMidSquare.Text = wins[1].ToString();
                txtWinsFolding.Text = wins[2].ToString();
                txtWinsMultiplication.Text = wins[3].ToString();

                // Лучшая функция (максимальное t) выбирается для сравнения методов
                int best = 0;
                for (int f = 1; f < wins.Length; f++)
                    if (wins[f] > wins[best])
                        best = f;
                cmbHashFunction.SelectedIndex = best;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // ---------- Сравнение методов разрешения коллизий ----------

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Func<int, int> hash = HashFunctions.All[cmbHashFunction.SelectedIndex];
            int repeats = (int)nudRepeats.Value;

            Cursor = Cursors.WaitCursor;
            try
            {
                // 1. M1 - ключи для заполнения таблиц (1..10000)
                int[] m1 = new int[TableSize];
                for (int i = 0; i < m1.Length; i++)
                    m1[i] = rnd.Next(1, 10001);

                // 2-3. Заполнение МОА и МС одними и теми же ключами (дубликаты не вставляются)
                OpenAddressingTable openTable = new OpenAddressingTable(TableSize, hash);
                ChainedTable chainedTable = new ChainedTable(HashFunctions.AddressCount, hash);
                int inserted = 0;
                foreach (int key in m1)
                {
                    if (openTable.Insert(key))
                        inserted++;
                    chainedTable.Insert(key);
                }

                // 4. M2 - искомые ключи (1..20000)
                int[] m2 = new int[TableSize];
                for (int i = 0; i < m2.Length; i++)
                    m2[i] = rnd.Next(1, 20001);

                // 5. Поиск сначала в МОА, затем в МС; весь поиск M2 повторяется repeats раз
                int found = 0;
                long comparisons = 0;

                int start = Environment.TickCount;
                for (int r = 0; r < repeats; r++)
                    found = openTable.SearchAll(m2, out comparisons);
                int time = Environment.TickCount - start;
                txtTimeOA.Text = time.ToString();
                txtComparisonsOA.Text = ((double)comparisons / m2.Length).ToString("0.00");
                txtFoundOA.Text = found.ToString();
                Refresh();

                start = Environment.TickCount;
                for (int r = 0; r < repeats; r++)
                    found = chainedTable.SearchAll(m2, out comparisons);
                time = Environment.TickCount - start;
                txtTimeCh.Text = time.ToString();
                txtComparisonsCh.Text = ((double)comparisons / m2.Length).ToString("0.00");
                txtFoundCh.Text = found.ToString();

                lblMethodsInfo.Text = $"Функция: {HashFunctions.Names[cmbHashFunction.SelectedIndex]}. " +
                                      $"M1: {TableSize} ключей 1..10000 (без дубликатов вставлено {inserted}), " +
                                      $"M2: {TableSize} ключей 1..20000.";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
