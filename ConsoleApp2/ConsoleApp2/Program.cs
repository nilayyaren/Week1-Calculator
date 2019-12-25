using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı1 i giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı 2 yi giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            islem:
            Console.WriteLine("toplama için + ; çıkarma için - ; çarpma için * ; bölme için / basınız..");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '+':
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case '-':
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case '*':
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case '/':
                    //double a = Convert.ToDouble(sayi1);
                    //double b = Convert.ToDouble(sayi2);
                    //Console.WriteLine(a/b);
                    Console.WriteLine(1.0f * sayi1 / sayi2);
                    break;
                default:
                    Console.WriteLine("geçerli bir işlem tanımlayın!");
                    goto islem;
                    break;
            }
            Console.ReadLine();
        }
    }
}
