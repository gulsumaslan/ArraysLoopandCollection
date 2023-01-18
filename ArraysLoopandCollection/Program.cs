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
            int[] numbers = { 10, 23, 24, 68, 79, 80, 64, 46, 53, 52, 40, 60, 90, 66, 88, 22, 44, 67 };
            int counter = 0;
            int total = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    counter++;
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine("Number of even numbers:" + counter);


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
            string[] cities = new string[5];
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("Enter city name");
                cities[i] = Console.ReadLine();


            }
            Console.WriteLine("the initials of the city you want to list");
            char harf = Convert.ToChar(Console.ReadLine());

            foreach (var city in cities)
            {
                if (city[0] ==letter)
                {
                    Console.WriteLine(city);

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
