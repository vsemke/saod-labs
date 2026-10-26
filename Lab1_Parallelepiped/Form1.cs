using System.Drawing.Drawing2D;

namespace Lab1_Parallelepiped
{
    public partial class Form1 : Form
    {
        // Начальные значения сторон (задаются в Form1_Load и при двойном щелчке)
        private const decimal InitialA = 3;
        private const decimal InitialB = 4;
        private const decimal InitialC = 5;

        public Form1()
        {
            InitializeComponent();
        }

        // Событие Load: начальные значения сторон
        private void Form1_Load(object sender, EventArgs e)
        {
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            nudA.Value = InitialA;
            nudB.Value = InitialB;
            nudC.Value = InitialC;
            ClearResults();
        }

        private void ClearResults()
        {
            txtS.Text = "";
            txtV.Text = "";
        }

        // Кнопка «Вычислить»: S = 2(ab + bc + ac), V = abc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a = (double)nudA.Value;
            double b = (double)nudB.Value;
            double c = (double)nudC.Value;

            txtS.Text = Algorithms.SurfaceArea(a, b, c).ToString("0.######");
            txtV.Text = Algorithms.Volume(a, b, c).ToString("0.######");
        }

        // Двойной щелчок по любому полю ввода возвращает все стороны к начальным значениям
        private void nudSide_DoubleClick(object sender, EventArgs e)
        {
            SetInitialValues();
        }

        // При изменении стороны старые результаты сбрасываются, рисунок перерисовывается
        private void nudSide_ValueChanged(object sender, EventArgs e)
        {
            ClearResults();
            panelPicture.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Рисунок параллелепипеда: передняя грань ABCD, задняя EFGH.
        // a - ширина (AB), b - глубина (BF), c - высота (AD).
        // Пропорции рисунка соответствуют введенным сторонам.
        private void panelPicture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float a = (float)nudA.Value;
            float b = (float)nudB.Value;
            float c = (float)nudC.Value;
            float max = Math.Max(a, Math.Max(b, c));
            if (max <= 0)
                return;

            // Относительные размеры (не меньше 0.2, чтобы рисунок не вырождался в линию)
            float wa = Math.Max(a / max, 0.2f);
            float wb = Math.Max(b / max, 0.2f);
            float wc = Math.Max(c / max, 0.2f);

            // Глубина рисуется под углом 45° с сокращением вдвое (кабинетная проекция)
            float dx = wb * 0.5f * 0.7071f;
            float dy = dx;

            // Область рисования (сверху место под заголовок панели)
            RectangleF area = new RectangleF(45, 55, panelPicture.ClientSize.Width - 90, panelPicture.ClientSize.Height - 90);
            float scale = Math.Min(area.Width / (wa + dx), area.Height / (wc + dy));
            float left = area.Left + (area.Width - (wa + dx) * scale) / 2;
            float bottom = area.Bottom - (area.Height - (wc + dy) * scale) / 2;

            PointF A = new PointF(left, bottom);
            PointF B = new PointF(A.X + wa * scale, A.Y);
            PointF C = new PointF(B.X, B.Y - wc * scale);
            PointF D = new PointF(A.X, C.Y);
            SizeF depth = new SizeF(dx * scale, -dy * scale);
            PointF E = A + depth;
            PointF F = B + depth;
            PointF G = C + depth;
            PointF H = D + depth;

            using Pen solid = new Pen(Color.FromArgb(0, 51, 102), 2);
            using Pen dashed = new Pen(Color.FromArgb(0, 51, 102), 1) { DashStyle = DashStyle.Dash };

            // Невидимые ребра - пунктиром
            g.DrawLine(dashed, A, E);
            g.DrawLine(dashed, E, F);
            g.DrawLine(dashed, E, H);

            // Видимые ребра: передняя, верхняя и правая грани
            g.DrawPolygon(solid, new[] { A, B, C, D });
            g.DrawPolygon(solid, new[] { D, C, G, H });
            g.DrawPolygon(solid, new[] { B, F, G, C });

            // Подписи вершин
            using Font vertexFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            DrawLabel(g, "A", vertexFont, A, -18, -2);
            DrawLabel(g, "B", vertexFont, B, 3, -2);
            DrawLabel(g, "C", vertexFont, C, -17, 2);
            DrawLabel(g, "D", vertexFont, D, -18, -18);
            DrawLabel(g, "E", vertexFont, E, 3, -18);
            DrawLabel(g, "F", vertexFont, F, 4, -6);
            DrawLabel(g, "G", vertexFont, G, 3, -18);
            DrawLabel(g, "H", vertexFont, H, -18, -18);

            // Подписи сторон a, b, c
            using Font sideFont = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            DrawLabel(g, "a", sideFont, Middle(A, B), -5, 2);
            DrawLabel(g, "b", sideFont, Middle(B, F), 6, 0);
            DrawLabel(g, "c", sideFont, Middle(A, D), -20, -10);
        }

        private static PointF Middle(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }

        private static void DrawLabel(Graphics g, string text, Font font, PointF point, float offsetX, float offsetY)
        {
            g.DrawString(text, font, Brushes.Black, point.X + offsetX, point.Y + offsetY);
        }
    }
}
