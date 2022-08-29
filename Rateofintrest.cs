using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Rateofintrest
    {
        static int GetIntrestAmount(int principleAmount,int tenure,int interestRate)
            {
            int interestAmount = 0;
            // SI=PTR/100
            
            interestAmount = (principleAmount * tenure * interestRate)/100;

            return interestAmount;
            }
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the principle Amount");
            var principleAmount = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("enter the tenure");
            var tenure = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the interest Rate");
            var intrestRate = Convert.ToInt32(Console.ReadLine());

            var result = GetIntrestAmount(principleAmount,tenure,intrestRate);
            Console.WriteLine($"result:{result}");
        } 
    }
 }
