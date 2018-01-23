using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromsayi
{
    class Program
    {
        static void Main(string[] args)
        {
       //int  tersSayi=0;
           int carpım;
            for (int i = 999; i >=100; i--)
            {
                for (int j = 999; j >=100; j--)
                {
                    carpım = i * j;
                    PalindromSayiyiBul(carpım);
                    
                    
                }


            }
          
            Console.ReadLine();

        }
        public static int PalindromSayiyiBul(int sayi)
        {
            int tersSayi = 0;
            while (sayi > 0)
            {

                tersSayi = tersSayi * 10 + sayi % 10;
                sayi /= 10;

            }
            if (tersSayi == sayi)
            {
                Console.WriteLine("palindrom sayi:" + tersSayi);

            }
            else
            {
                Console.WriteLine("palindrom sayi değildir");
            }
            return tersSayi;
        }
    }
}
