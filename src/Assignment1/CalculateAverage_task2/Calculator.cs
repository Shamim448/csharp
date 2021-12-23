using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverage_task2
{
    public static class Calculator
    {       
        public static double CalculateAverage()
        {
            return 0;
        }
        public static double CalculateAverage( double num1, double num2)
        {
            return (num1 + num2)/2;
        }
        public static double CalculateAverage(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }
        public static double CalculateAverage(double[] arra, double sum=0)
        {
            
           
            foreach(var arra2 in arra)
            {
                sum +=  arra2;
            }
            
            return sum/ arra.Length; 
        }
    }
}
