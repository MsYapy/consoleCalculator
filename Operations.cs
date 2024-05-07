using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace basicA
{
    internal class Operations
    {

        public decimal result { set; get; }
        private decimal num1 = 0;
        private decimal num2 = 0;

        private decimal getValues()
        {
                Console.WriteLine("Ingrese el valor");
                string values = Console.ReadLine();
                decimal num = decimal.Parse(values);
                return num;
        }

        public decimal DeleteResult() 
        { 
            result = 0;

            return result;
        }
        public decimal sumar() 
        {
            if (result == 0) 
            {
                num1 = getValues();
                num2 = getValues();
                result = num1 + num2;   
                return result;
            }    
            num2 = getValues(); 
            result = num2 + result;
            return result;   
        }
        public decimal Restar()
        {
            if (result == 0)
            {
                num1 = getValues();
                num2 = getValues();
                result = num1 - num2;
                return result;
            }
            num2 = getValues();
            result = result - num2;
            return result;
        }
        public decimal Multiplicar()
        {
            if (result == 0)
            {
                num1 = getValues();
                num2 = getValues();
                result = num1 * num2;
                return result;
            }
            num2 = getValues();
            result = result * num2;
            return result;
        }
        public decimal Divividir()
        {
            if (result == 0)
            {
                do
                {
                    Console.WriteLine("Escoja un numero diferente a 0");
                    num1 = getValues();
                }
                while (num1 == 0);
                num2 = getValues();
                result = num1 / num2;
                return result;
            }
            num2 = getValues();
            result = result / num2;
            return result;

        }

    }
}
