namespace Lab1_Parallelepiped
{
    /// <summary>
    /// Расчет параметров прямоугольного параллелепипеда со сторонами a, b, c.
    /// </summary>
    public static class Algorithms
    {
        /// <summary>
        /// Площадь полной поверхности: S = 2(a·b + b·c + a·c).
        /// </summary>
        public static double SurfaceArea(double a, double b, double c)
        {
            return 2 * (a * b + b * c + a * c);
        }

        /// <summary>
        /// Объем: V = a·b·c.
        /// </summary>
        public static double Volume(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
