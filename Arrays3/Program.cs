using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] kullaniciAdlari = new string[]
            //    {
            //     "zeynep", "serhat" ,"cankus"
            //    };
            //string[] sifreler = new string[]
            //{
            //      "z123","s123","c123"
            //};

            //Console.WriteLine("Kullanici adinizi girin : ");
            //string kullaniciGiris = Console.ReadLine();
            //Console.WriteLine("Sifrenizi giriniz :");
            //string sifreGiris = Console.ReadLine();

            //bool bulundu = false;

            //for (int i = 0; i < kullaniciAdlari.Length; i++)
            //{
            //    if (kullaniciAdlari[i] == kullaniciGiris && sifreler[i] == sifreGiris)
            //    {
            //        bulundu = true;
            //        break;
            //    }
            //}
            //if (bulundu)
            //{
            //    Console.WriteLine("Hosgeldiniz : " + kullaniciGiris);
            //}
            //else
            //{
            //    Console.WriteLine("Kullanici adi veya sifre hatali");
            //}

            // ***
            string[,] users = new string[3, 2];
            
            users[0,0] = "zeynep";
            users[0, 1] = "z123";
            users[1, 0] = "serhat";
            users[1, 1] = "s123";
            users[2, 0] = "cankus";
            users[2, 1] = "c123";

            Console.WriteLine("Kullanici adi giriniz : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Sire giriniz : ");
            string UserPassword = Console.ReadLine();

            bool found = false;
            for (int row = 0; row <= users.GetUpperBound(0); row++)
            {
                if (users[row,0] == userName && users[row,1] == UserPassword)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Welcome" + " " +  userName);
            }
            else
            {
                Console.WriteLine("The password is wrong");
            }


            Console.Read();
        }
    }
}
