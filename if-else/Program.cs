using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int Id = 32786532;
                int AccountNumber = 002753809;
                String Name = "Faiqa Yousuf";
                int ConsumedUnit = 786;
                int ConsumedUnitCost = 0;

                if (ConsumedUnit <= 100)
                {
                    ConsumedUnitCost = 22;
                }
                else if (ConsumedUnit <= 200)
                {
                    ConsumedUnitCost = 32;
                }
                else if (ConsumedUnit <= 300)
                {
                    ConsumedUnitCost = 37;
                }
                else if (ConsumedUnit <= 400)
                {
                    ConsumedUnitCost = 43;
                }
                else if (ConsumedUnit <= 500)
                {
                    ConsumedUnitCost = 47;
                }
                else if (ConsumedUnit <= 600)
                {
                    ConsumedUnitCost = 49;
                }
                else if (ConsumedUnit <= 700)
                {
                    ConsumedUnitCost = 52;
                }
                else
                {
                    ConsumedUnitCost = 65;
                }

                Console.WriteLine("Id : " + Id);
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Account Number : " + AccountNumber);
                Console.WriteLine("Consumed Unit : " + ConsumedUnit);
                Console.WriteLine("Consumed Unit Cost : " + ConsumedUnitCost);

                Console.ReadLine();
            }
        }
    }
   
