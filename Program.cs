using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight ("Arus", "Knight", 42, 749, 72, "Sword");

            Ninja wedge = new Ninja ("Wedge", "Ninja", 42, 574, 89, "Kunai");
            
            Wizard jenica = new Wizard ("Jenica", "White Wizard", 45, 601, 482, "Rod");
       
            Wizard topapa = new Wizard ("Topapa", "Black Wizard", 44, 385, 641, "Staff");
            

            Console.WriteLine(arus + "\n" + arus.Attack() + "\n");
            Console.WriteLine(wedge + "\n" + wedge.Attack() + "\n");
            Console.WriteLine(jenica + "\n" +jenica.Attack(5) + "\n");
            Console.WriteLine(topapa + "\n" + topapa.Attack(20) + "\n");

       }
    }
}
