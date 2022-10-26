using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int faktor1, int faktor2)
        {
            return faktor1 * faktor2;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException();
            }
            else
                return dividend / divisor;
        }

    }
}
