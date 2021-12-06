using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArraysLoopandCollection
{
    class Program
    {
               //ARRAYS
            static void Main(string[] args)
            {
            int[] sayilar = { 10, 23, 24, 68, 79, 80, 64, 46, 53, 52, 40, 60, 90, 66, 88, 22, 44, 67 };
            int sayac = 0;
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    sayac++;
                    Console.WriteLine(sayi);
                }
            }
            Console.WriteLine("Çift sayı adedi:" + sayac);


            Console.WriteLine("++++++++++++++++++++++++++");


                   //collection  ARRAYLİST remove count 

            ArrayList arrays = new ArrayList();
            arrays.Add(20);
            arrays.Add("gülsüm");
            arrays.Add(766);
            arrays.Add('A');

            foreach (var array in arrays)
            {
                Console.WriteLine(array);
            }
                arrays.Remove(20);

                for (int i = 0; i < arrays.Count; i++)
                {
                    Console.WriteLine(arrays[i]);
                }




            Console.WriteLine("++++++++++++++++++++++++++++++++");


            //LOOPS
            string[] sehirler = new string[5];
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine("Şehir adını giriniz");
                sehirler[i] = Console.ReadLine();


            }
            Console.WriteLine("listelemek istediğiniz şehrin baş harfi");
            char harf = Convert.ToChar(Console.ReadLine());

            foreach (var sehir in sehirler)
            {
                if (sehir[0] ==harf)
                {
                    Console.WriteLine(sehir);

                }
            }



            //List<Teachers> teacher= new List<Teachers>();
            //teacher.Add(new Teachers { TC = 111111, FirstName = "gülsüm", LastName = "Aslan" });
           

            //foreach (var t in teacher)
            //{
            //    Console.WriteLine(t);

                

            //}

            }
        }

    //class Teachers
    //{
    //    public int TC { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //}
    }
