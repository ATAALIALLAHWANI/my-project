using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public  class JaggedArray { 
   
        public static void amin()
        {
            int[][] Myarray = CreateArray(4);
            popurate(Myarray);
            printarr(Myarray);
           
        }

        public static void popurate(int [] [] arrpopur)
        {
            Random ram = new Random();
          for (int i = 0; i< arrpopur.GetLength(0); i++)
            {
                arrpopur[i] = new int[i+2 ];  
                for(int g =0; g < arrpopur[i].Length; g++)
                {
                    arrpopur[i][g] = ram.Next(1, 100);
                }
               
            }
        }
        public static int [] [] CreateArray(int Lengh)
        {
            int[][] arr = new int[Lengh][];
            return arr;
        }


        public static void printarr(int [] [] arrprint)
        {
            for (int i = 0; i < arrprint.GetLength(0); i++)
            {
                int[] e = arrprint[i];
                for (int g = 0; g < e.Length; g++)
                {
                    Console.Write($"{e[g]}    ");
                }
                Console.WriteLine(); 
            }

            //foreach (int [] e in arrprint)
            //{
            //    foreach(int i in e) { Console.Write($"{i }  ");  }
            //}

        }
    }
    


}
