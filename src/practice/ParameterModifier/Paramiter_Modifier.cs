using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class Paramiter_Modifier
    {
       //public int Sum(int num1, int num2)
       // {
       //     return num1 + num2;
       // }
       // public int Sum(int num1, int num2, int num3)
       // {
       //     return num1 + num2+ num3;
       // }
        public int Sum(params int[] array )
        {
            int result = 0;
            foreach ( int item in array)
            {
                result = result + item;
            }

            return result;
        }
        public void UseParam(params object[] list)
        {            
            foreach (object item in list)
            {
                Console.Write("params parameter modifier =" + item + " ");
            }
            Console.WriteLine();// For blank line
        }

        //ref parameter modifier
         public void Parametr_ref(ref int a) {
            a = 10;
        }
        //in parameter modifier
        public void Parametr_in(in int a)
        {
            //a = 10; we can't assign value but it's refarancrce type
        }

        //out parameter modifier
        public void Parametr_out(out int a)
        {
            a = 20; //bust change valur and it value  type
        }
    }
}
