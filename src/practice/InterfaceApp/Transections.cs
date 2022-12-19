using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    internal class Transections : ITransection
    {

        private string tCode;
        private string tDate;
        private double tAmount;

        public Transections()
        {
            Console.WriteLine("Default constractor ");
        }
        public Transections(string tCode, string tDate, double tAmount)
        {
            this.tCode = tCode;
            this.tDate = tDate;
            this.tAmount = tAmount;
        }
        public double getAmount()
        {
            return tAmount;
        }
        public void showTransection()
        {
            Console.WriteLine("Transection : {0} ", tCode);
            Console.WriteLine("Date: {0} ", tDate);
            Console.WriteLine("Amount :{0} ", getAmount());
            
        }

       
    }
}
