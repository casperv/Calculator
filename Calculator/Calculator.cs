using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorShared
{
    public class Class1
    {


     /// <summary>
     /// Bruges til at lægge 2 tal sammen.
     /// </summary>
     /// <param name="a"></param>
     /// <param name="b"></param>
     /// <returns></returns>
        public double Plus(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Bruges til at trække 2 tal fra hinanden.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Minus(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Bruges til at gange 2 tal med hinanden.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Gange(double a, double b)
        {
            return a*b;
        }

        /// <summary>
        /// Bruges til at dividere 2 tal med hinanden.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Divider(double a, double b)
        {
            return a/b;
        }

    }
}
