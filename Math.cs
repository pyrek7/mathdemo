using System;

namespace MathSolution
{
    public class Math
    {
        public int Add(int a, int b)
        {
            return a+b;
        }

        public int Sub(int a, int b)
        {
            return a-b;
        }

        public double Div (int a, int b)
        {
            if(b==0)
                throw new DivideByZeroException();
            return (double)a/(double)b;    
        }
        public int Mul(int a, int b)
        {
            return a*b;
        }
    }
}
