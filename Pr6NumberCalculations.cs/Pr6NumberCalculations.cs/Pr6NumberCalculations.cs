using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr6NumberCalculations.cs
{
    class Pr6NumberCalculations
    {
        static void Main(string[] args)
        {
            string str;
            string[] arrStr;
            decimal[] arrnumDecimal;
            double[] arrnumDouble;
            double convertToDouble;
            decimal convertToDecimal;

            Console.WriteLine("Write a numbers separated by a space");
            str = Console.ReadLine();
            arrStr = str.Split(' ');
            arrnumDecimal=new decimal[arrStr.Length];
            arrnumDouble=new double[arrStr.Length];

            for (int i = 0; i <arrStr.Length; i++)
            {
                convertToDecimal = Convert.ToDecimal(arrStr[i]);
                arrnumDecimal[i] = convertToDecimal;

                convertToDouble = Convert.ToDouble(arrStr[i]);
                arrnumDouble[i] = convertToDouble;
                
                
            }

         MinDecimal( arrnumDecimal);
         MinDouble(arrnumDouble);
         MaxDecimal(arrnumDecimal);
         MaxDouble(arrnumDouble);
         AverageDecimal(arrnumDecimal);
         AverageDouble(arrnumDouble);
         SumDecimal(arrnumDecimal);
         SumDouble(arrnumDouble);
         ProductDecimal(arrnumDecimal);
         ProductDouble(arrnumDouble);




        }

        static void MinDecimal(decimal[] arrnumDecimal)
        {
            decimal min = arrnumDecimal[0];
            for (int i = 1; i < arrnumDecimal.Length; i++)
            {
                if (arrnumDecimal[i]<min)
                {
                    min = arrnumDecimal[i];
                }
               
            }

            Console.WriteLine("in decimal min= "+min);

        }

        static void MinDouble(double[] arrnumDouble)
        {
          double min=arrnumDouble[0];
            for (int i = 0; i < arrnumDouble.Length; i++)
            {
                if (arrnumDouble[i]<min)
                {
                    min=arrnumDouble[i];
                }
            }
            Console.WriteLine("in double min= " + min);
 
        }


        static void MaxDecimal(decimal[] arrnumDecimal)
        {
            decimal max=arrnumDecimal[0];
            for (int i = 0; i < arrnumDecimal.Length; i++)
            {
                if (arrnumDecimal[i] > max)
                {
                    max=arrnumDecimal[i] ;
                    
                }
            }
            Console.WriteLine("in decimal max= " + max);
        }


        static void MaxDouble(double[] arrnumDouble)
        {
            double max = arrnumDouble[0];
            for (int i = 0; i < arrnumDouble.Length; i++)
            {
                if (arrnumDouble[i]>max)
                {
                    max=arrnumDouble[i];
                    Console.WriteLine("in double max= " + max);
                }
            }
 
        }

        static void AverageDecimal(decimal[] arrnumDecimal)
        {
            decimal sum=arrnumDecimal[0];
            decimal average;
            for (int i = 0; i < arrnumDecimal.Length-1; i++)
            {
             sum+=arrnumDecimal[i+1];   
            }
            average = sum / 2;
            Console.WriteLine("in decimal average= " + average);
        }


        static void AverageDouble(double[] arrnumDouble)
        {
            double sum=arrnumDouble[0];
            double average;
            for (int i = 0; i <arrnumDouble.Length-1 ; i++)
			{
			 sum+=arrnumDouble[i+1];

			}
            average = sum / 2;
            Console.WriteLine("in  double average= " + average);
        }

        static void SumDecimal(decimal[] arrnumDecimal)
        {
            decimal sum=arrnumDecimal[0];
            for (int i = 0; i < arrnumDecimal.Length - 1; i++)
            {
                sum += arrnumDecimal[i + 1];
            }
            Console.WriteLine("in decimal sum= " +sum);
 
        }
        static void SumDouble(double[] arrnumDouble)
        {

            double sum = arrnumDouble[0];
            double average;
            for (int i = 0; i < arrnumDouble.Length - 1; i++)
            {
                sum += arrnumDouble[i + 1];

            }
            Console.WriteLine("in double sum= " + sum);
        }

        static void ProductDecimal(decimal[] arrnumDecimal)
        { 
            decimal product=arrnumDecimal[0];
            for (int i = 0; i < arrnumDecimal.Length-1; i++)
            {
                product*=arrnumDecimal[i+1];
            }
            Console.WriteLine("in decimal product= " + product);
        }

        static void ProductDouble(double[] arrnumDouble)
        { 
            double product=arrnumDouble[0];
            for (int i = 0; i < arrnumDouble.Length-1; i++)
            {
                product*=arrnumDouble[i+1];
            }
            Console.WriteLine("in double product= " + product);
        }

    }
}
