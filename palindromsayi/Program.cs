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
      
           int carpım;
            int buyukSayi = 0;
            for (int i = 999; i >=100; i--)
            {
                for (int j = 999; j >=100; j--)
                {
                    carpım = i * j;
                   int sayi= PalindromSayiyiBul(carpım);
                    if (sayi >= buyukSayi)
                    {
                        buyukSayi = sayi;
                        
                    }
                   
                    
                }


            }
            Console.WriteLine(buyukSayi);
            Console.ReadLine();

        }
        public static int PalindromSayiyiBul(int sayi)
        {
            int tersSayi = 0;
            int yeniSyi = sayi;
            while (yeniSyi > 0)
            {
                
                tersSayi = tersSayi * 10 + yeniSyi % 10;
                yeniSyi /= 10;

            }
            if (tersSayi == sayi)
            {
                return tersSayi;

            }
            else
            {
                return 0;
            }
          
        }
    }
}
