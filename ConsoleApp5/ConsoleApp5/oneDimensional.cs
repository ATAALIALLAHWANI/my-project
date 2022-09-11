using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class oneDimensional
    {
        public static int[] CreateArray(int Lengh)
        {
            int[] arr = new int[Lengh];
            return arr;
        }

        public static void printMyarray(int[] arrprint)
        {
            foreach (int e in arrprint)
            {

                Console.Write($"{e}" + "  ");
            }
            Console.WriteLine();
        }

        public static void populateArray(int[] arrpupulate)
        {
            Random randm = new Random();
            for (int i = 0; i < arrpupulate.Length; i++)
            {
                arrpupulate[i] = randm.Next(1, 100);
            }
        }

        public class Car
        {

            public string Name { get; set; }

            public string Model { get; set; }

            public Car(string n, string m)
            {
                Name = n;
                Model = m;
            }

            public override string ToString()
            {
                return $"{Name}  {Model}";
            }
        }

        public static void populateCar(Car[] carpopulate)
        {
            Random ram = new Random();
            for (int i = 0; i < carpopulate.Length; i++)
            {
                string s = "" + i;
                carpopulate[i] = new Car(s, s);
            }
        }

        public static void printcar(Car[] printcars)
        {
            foreach (Car e in printcars)
            {
                Console.Write($"{e}  ");
            }
        }



        public static Car[] CreateCar(int Lengh)

        {
            Car[] arrc = new Car[Lengh];
            return arrc;
        }


        public static void amin3()
        {
            int[] Myarray = CreateArray(5);
            populateArray(Myarray);
            printMyarray(Myarray);

            Console.WriteLine("the car arr ...");

            Car[] Mycar = CreateCar(3);
            populateCar(Mycar);
            printcar(Mycar);
        }

    }
}
