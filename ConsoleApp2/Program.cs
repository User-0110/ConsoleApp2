﻿// autogenerated 

using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;



namespace project
{

    class Program
    {
        class x_System
        {
        }
        static void Main(string[] args)
        {

            string[] List = new string[]
            {
                "1. 2x2?", "2. 3x3?"
            };

            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine(List[i]);
            }
            int j = Convert.ToInt32(Console.ReadLine());
            switch(j)
            {
                case 1:
                    int a11 = Convert.ToInt32(Console.ReadLine());
                    int a12 = Convert.ToInt32(Console.ReadLine());
                    int a21 = Convert.ToInt32(Console.ReadLine());
                    int a22 = Convert.ToInt32(Console.ReadLine());

                    int det = a11 * a22 - a21 * a12;
                    Console.WriteLine("Определитель = " + det);
                    break;
                case 2:
                    int b11 = Convert.ToInt32(Console.ReadLine());
                    int b12 = Convert.ToInt32(Console.ReadLine()); 
                    int b13 = Convert.ToInt32(Console.ReadLine());
                    int b21 = Convert.ToInt32(Console.ReadLine());
                    int b22 = Convert.ToInt32(Console.ReadLine());
                    int b23 = Convert.ToInt32(Console.ReadLine());
                    int b31 = Convert.ToInt32(Console.ReadLine());
                    int b32 = Convert.ToInt32(Console.ReadLine());
                    int b33 = Convert.ToInt32(Console.ReadLine());

                    int det_ = b11 * (b22 * b33 - b32 * b23) - b12 * (b21 * b33 - b31 * b23) + b13 * (b21 * b32 - b31 * b22);
                    Console.WriteLine("Определитель = " + det_);
                    break;
                default:
                    Console.WriteLine("Ты даун?");
                    break;
            }
        }
    }
    
}