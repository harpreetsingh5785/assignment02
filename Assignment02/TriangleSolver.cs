using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {
        private static int sideA;
        private static int sideB;
        private static int sideC;
        static TriangleSolver()
        {
            sideA = 1;
            sideB = 1;
            sideC = 1;

        }
        public static string Analyze(int a, int b, int c)
        {
            TriangleSolver.sideA = a;
            TriangleSolver.sideB = b;
            TriangleSolver.sideC = c;

            string display = "";
            if (TriangleSolver.sideA + TriangleSolver.sideB <= TriangleSolver.sideC ||
                TriangleSolver.sideA + TriangleSolver.sideC <= TriangleSolver.sideB ||
                TriangleSolver.sideB + TriangleSolver.sideC <= TriangleSolver.sideA)
            {
                display = "Triangle is not formed";
            }
            else
            {
                if (TriangleSolver.sideA == TriangleSolver.sideB && TriangleSolver.sideB == TriangleSolver.sideC && TriangleSolver.sideC == TriangleSolver.sideA)
                {
                    display = "It is an Equilateral Triangle";
                }
                else if (TriangleSolver.sideA == TriangleSolver.sideB || TriangleSolver.sideA == TriangleSolver.sideC || TriangleSolver.sideB == TriangleSolver.sideC)
                {
                    display = "It is Isosceles Triangle";

                }
                else if (TriangleSolver.sideA != TriangleSolver.sideB && TriangleSolver.sideB != TriangleSolver.sideC && TriangleSolver.sideC != TriangleSolver.sideA)
                {
                    display = "It is Scalene Triangle";
                }

            }
            return display;
        }
    }
}
