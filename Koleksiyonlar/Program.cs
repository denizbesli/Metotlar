using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Deniz", "Burak", "Yasemin", "Hakan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler2.Add("ilker");
            //Console.WriteLine(isimler2[4]);
            //Console.WriteLine(isimler2[0]);

            //List<string> isimler2 = new List<string>(); 1. kullanım
            //isimler2.Add("Deniz");

            List<string> isimler2 = new List<string> { "Deniz", "Burak","Yasemin", "Hakan"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


            //Koleksiyonlarda arrayler gibi değerlerini kaybetmeyecek alt yapı var. İş hayatında array fazla kullanılmaz onun yerine list kullanılır.



        }
    }
}
