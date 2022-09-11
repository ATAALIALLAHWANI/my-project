using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class twoDimemsoinal
    {
        public static int[,] CareatTable(int rows, int colums)
        {
            int[,] arr = new int[rows, colums];
            return arr;
        }

        public static void prinTable(int[,] arrprint)
        {
            for (int i = 0; i < arrprint.GetLength(0); i++)
            {
                for (int g = 0; g < arrprint.GetLength(1); g++)
                {
                    Console.Write($"{arrprint[i, g]}  ");
                }
                Console.WriteLine();
            }

            //foreach (int e in arrprint)
            //{
            //    Console.Write($"{e}  ");
            //}
            //Console.WriteLine();
        }
        public static void Poplurateint(int[,] arrpopurate)
        {
            Random ram = new Random();
            for (int i = 0; i < arrpopurate.GetLength(0); i++)
            {
                int r = ram.Next(1, 100);
                for (int g = 0; g < arrpopurate.GetLength(1); g++)
                {
                    arrpopurate[i, g] = r;
                }

            }
        }

        public class Car
        {
            public int number;
            public int model;

            public Car(int n, int m)
            {
                number = n;
                model = m;
            }
            public override string ToString()
            {
                return $"({number} {model} )";
            }


        }

        /// <summary>
        /// //////////////
        /// </summary>
        /// <param ></param>
        /// 

        public static Car[,] CreTable(int rows, int colums)
        {
            Car[,] arrc = new Car[rows, colums];
            return arrc;
        }

        public static void printCar(Car[,] arrprintc)
        {
            foreach (object e in arrprintc)
            {
                Console.Write($"{e}  ");
            }
        }

        public static void CarPopurate(Car[,] carPap)
        {
            Random ram = new Random();
            for (int i = 0; i < carPap.GetLength(0); i++)
            {
                int r = ram.Next(1, 100);
                for (int g = 0; g < carPap.GetLength(1); g++)
                {
                    carPap[i, g] = new Car(r, r);
                }

            }


        }



        public static void amin2()
        {
            int[,] Myarray = CareatTable(2, 4);
            Poplurateint(Myarray);
            prinTable(Myarray);

            Console.WriteLine("the Car  value  is  = ");

            Car[,] MyCar2 = CreTable(2, 2);
            CarPopurate(MyCar2);
            printCar(MyCar2);

        }

    }
}

