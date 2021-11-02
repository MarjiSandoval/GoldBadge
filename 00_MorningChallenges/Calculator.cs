using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        //This is how you add mulit numbers
        public decimal Add(params decimal[] numbers)
        {
            //we have to start somewhere..
            //so well start at zero,
            //but to use this I need to store it in a container 'startignVal'
            decimal startingVal = 0;
            if (numbers.Length>0)
            {
                startingVal += numbers[0];
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                startingVal += numbers[i];
            }
            return startingVal;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }
        public decimal Subtract(params decimal[] numbers)
        {
            decimal startingVal = 0;
            if (numbers.Length>0)
            {
                //startingVal = startingVal - numbers[0];
                startingVal += numbers[0];
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                startingVal += numbers[i];
            }
            return startingVal;
        }
        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }
        public decimal Multiply(params decimal[] numbers)
        {
            decimal startingVal = 1;
            if (numbers.Length>0)
            {
                startingVal = startingVal * numbers[0];
            }
            for (int i = 1; i < numbers.Length; i++)
            {

                //startingVal = startingVal * numbers[i];
                startingVal *= numbers[i];
            }
            return startingVal;
        }
        public decimal Divide(params decimal[] numbers)
        {
            decimal startingVal = 1;
            if (numbers.Length>0)
            {
                startingVal *= numbers[0];
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (i !=0)
                {
                    //startingVal = startingVal / numbers[i];
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
