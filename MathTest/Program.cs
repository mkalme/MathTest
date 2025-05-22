using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            test2();
            test();

            int[] range = { 1, 100 };
            Random rand = new Random();

            int buffer = 0;

            int b1 = 0;
            int b2 = 0;

            int simulationRepeat = 10000000;
            for (int i = 0; i < simulationRepeat; i++) {
                //Thread.Sleep(10);

                int point1 = rand.Next(range[1] - range[0] + 1) + range[0];
                int point2 = rand.Next(range[1] - range[0] + 1) + range[0];
                //int point2 = rand.Next(range[1] - point1 + 1) + point1;

                buffer += Math.Abs(point2 - point1);
                b1 += point1;
                b2 += point2;

                //Console.Clear();
                //Console.WriteLine("Simulation #" + i + " || " + "Average length: " + ((double)buffer / (double)i));
            }

            //Console.Clear();
            Console.WriteLine("Average length: " + ((double)buffer / (double)simulationRepeat));
            Console.WriteLine("Average range: " + ((double)b1 / (double)simulationRepeat) + "; " + ((double)b2 / (double)simulationRepeat));

            Console.ReadLine();
        }

        private static void test() {
            Random rand = new Random();

            int[] range = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21,
            22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44,
            45, 46, 47, 48, 49, 50};

            int[] range1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21,
            22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44,
            45, 46, 47, 48, 49, 50, 51};


            double average = 0;

            for (int i = 0; i < range.Length; i++) {
                average += range[i] * (range1[i]);
            }
            average /= range1.Sum();

            Console.WriteLine("Average: " + average);
        }

        private static void test2() {
            int[] range = {0, 100};

            Random rand = new Random();

            int[] posibility = new int[range[1] - range[0] + 1];
            double[] percentage = new double[range[1] - range[0] + 1];

            int simulation = 100;

            for (int b = 0; b < percentage.Length; b++) {
                double average = 0;

                for (int i = 0; i < simulation; i++) {
                    int point1 = rand.Next(range[1] - range[0] + 1) + range[0];
                    posibility[point1]++;
                    average += point1;
                }
                average /= (double)simulation;
                percentage[(int)average] = average;
            }


            for (int i = 0; i < percentage.Length; i++) {
                //Console.WriteLine("#" + (i + range[0]) + ": " + percentage[i]);
            }


            //Console.ReadLine();
        }
    }
}
