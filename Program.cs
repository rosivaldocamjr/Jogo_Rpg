using System;
using dotnet__poo.src.Entities;

namespace dotnet__poo
{   
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 25, "White Wizard");
            Ninja ninja = new Ninja("Joca", 22, "Ninja");

            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(4));
            Console.WriteLine(ninja.Attack());
            
        }
    }
}

