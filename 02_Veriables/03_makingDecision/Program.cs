using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_makingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else





            Console.Write("Lütfen Şifreyi giriniz:  ");
            string password;
                password= Console.ReadLine();
            if (password == "abcd") 

            {


                Console.WriteLine("Şifre Doğru");


            }
            else
            {
                Console.WriteLine("şifre yanlış");



            }

            Console.ReadKey();




            #endregion




        }
    }
}
