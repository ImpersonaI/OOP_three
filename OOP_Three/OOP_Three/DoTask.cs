using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Three
{
    class DoTask
    {
        static private int N = 0, M = 0;
        public void Input()
        {
            Console.WriteLine("Input N");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input M");
            M = Convert.ToInt32(Console.ReadLine());

            double[,] array = new double[N, M];
            double[] arrayM = new double[M]; //array for summarizing

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                    Console.WriteLine("Input array[" + (i + 1).ToString() + "]" + "[" + (j + 1).ToString() + "]");
                    array[i, j] = Convert.ToDouble(Console.ReadLine());

                    arrayM[i] += array[i, j];
                }
                arrayM[i] /= M;
            }

            Console.WriteLine("Inputted array");
             
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                    Console.Write( array[i,j] + "\t" );
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("Среднее арифметичесоке");

            for (int i = 0; i < M; i++)
            {

                Console.Write(arrayM[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (array[i,j] < arrayM[i])
                    {
                        array[i, j] = 0;
                    }

                    if (array[i, j] > arrayM[i])
                    {
                        array[i, j] = 1;
                    }


                    Console.Write(array[i, j] + "\t");

                }
                Console.WriteLine();
            }

        }

        public void DoMath()
        {


        }
    }
}