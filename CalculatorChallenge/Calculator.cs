using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;

        }
        public int Subtract(int a, int b)
        {
            int product = b - a;
            return product;
        }
        public int multiply(int a, int b)
        {
            int answer = a * b;
            return answer;
        }
        public int divide(int a, int b)
        {
            int quotient = a / b;
            return quotient;

        }
        public decimal divide(decimal a, decimal b)
        {
            decimal quotient = a / b;
            return quotient;
        }
        public decimal Add(decimal a, decimal b)
        {
            decimal sum = a + b;
            return sum;

        }
        public decimal Subtract(decimal a, decimal b)
        {
            decimal product = b - a;
            return product;
        }
        public decimal multiply(decimal a, decimal b)
        {
            decimal answer = a * b;
            return answer;
        }
        //This is how you add multiple numbers
        public decimal Add(params decimal[] numbers)
        {
            //We have to start somewhere...
            //so we will start at 0,
            //but to use this I need it in a container 'startingVal'
            decimal startingVal = 0;
            if (numbers.Length > 0)
            {
                startingVal += numbers[0];
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                startingVal += numbers[i];
            }
            return startingVal;
        }
        public decimal Subtract(params decimal[] numbers)
        {
            //We have to start somewhere...
            //so we will start at 0,
            //but to use this I need it in a container 'startingVal'
            decimal startingVal = 0;
            if (numbers.Length > 0)
            {
                startingVal -= numbers[0];
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                startingVal += numbers[i];
            }
            return startingVal;
        }
        public decimal multiply(params decimal[] numbers)
        {
            //We have to start somewhere...
            //so we will start at 0,
            //but to use this I need it in a container 'startingVal'
            decimal startingVal = 0;
            if (numbers.Length > 0)
            {
                startingVal *= numbers[0];
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                startingVal += numbers[i];
            }
            return startingVal;
        }
        public decimal divide(params decimal[] numbers)
        {
            //We have to start somewhere...
            //so we will start at 0,
            //but to use this I need it in a container 'startingVal'
            decimal startingVal = 0;
            if (numbers.Length > 0)
            {
                startingVal *= numbers[0];
            }
            for (int i = 1; i < numbers.Length; i++)
            {
               if (i != 0)
                {
                    startingVal /= numbers[i];
                }
            }
            return startingVal;
        }
        //if you want to take the fraction approach: https://www.codeproject.com/articles/11971/fractions-in-c

        public string Add_FractionFormat(decimal a, decimal b)
        {
            decimal value = a + b;
            string toFraction = $"{a}/{b}";
            return toFraction;
        }
        public string Percent(double a, double b)
        {
            double c = a / b;
            c *= 100;
            return $"{c}%";
        }
        public string Percent(int a, int b)
        {
            int c = a / b;
            c *= 100;
            return $"{c}%";
        }
    }

}

