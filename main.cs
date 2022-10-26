// Created by: sophie
// Created on: oct 2020
//
// This program calculates area of a trapezoid

using System;

class Program
{
    public static void Main(string[] args)
    {
        int baseA;
        int baseB;
        int height;
        int area;

        Console.WriteLine("calculates the area of a trapezoid.");
        Console.WriteLine("");

        Console.Write("Enter base a: ");
        baseA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter base b: ");
        baseB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height: ");
        height = Convert.ToInt32(Console.ReadLine());

        area = ((baseA + baseB) / 2) * height;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + ". ");

        Console.WriteLine("\nDone.");
    }
}