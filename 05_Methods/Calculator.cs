using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Methods
{
    //we want to make methods ....
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            //int sum = num1 + num2;
            //return sum;
            return num1 + num2;
        }

        //subtract
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        //multiply
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        //divide
        public decimal Divide(decimal a, decimal b)
        {
            //if (b !=0)
            //{
            //    return a / b;
            //}
            //else
            //{
            //    return 0;
            //}

            return (b!=0) ? a/b : 0;
        }

        //Modulus '%'
        public int FindRemainder(int a, int b)
        {
            return a % b;
        }
    }
}
