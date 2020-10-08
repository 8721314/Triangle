using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideint1, int sideint2, int sideint3)
        {

            string result = "The given inputs doesnot form a triangle!!";
            if (sideint1 + sideint2 > sideint3 && sideint1 + sideint3 > sideint2 && sideint2 + sideint3 > sideint1)
            {

                if ((sideint1 == sideint2) && (sideint2 == sideint3))
                {
                    //result = result + "Equilateral Triangle";
                    result = "Equilateral Triangle";
                }
                //a == b or b=c or a =c
                else if ((sideint1 == sideint2) || (sideint2 == sideint3) || (sideint3 == sideint1))
                {
                    result = "Isoceles Triangle";
                }
                else if (sideint1 != sideint2 && sideint2 != sideint3)
                {
                    result = "scalene triangle";
                }

            }
            return result;
        }
    }
}
