using System;

// namespace Faktöriyel
//{

// public class Program
//{

//  static int faktoriyel (int n)
//{
//  if (sayi <= 1)
// {
//  return 1;
// }
// else
// {
// return sayi * faktoriyel(sayi - 1);
// }
//}
//}
//}


namespace forFaktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(sayi + "! = " + faktoriyel);

        }
    }
}
namespace whileFaktoriyel
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            while (sayi > 0)
            {
                factorial *= sayi;
                sayi--;
            }
            Console.WriteLine(sayi + "!=" + factorial);
        }

    }

}
    
