using dz_6._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Web a = new Web ();
            a.Name = "Youtube";
            a.Url = "https://www.youtube.com/watch?v=9GDnI1tCoZM&t=32s";
            a.Description = "Music: Phonk";
            a.Ip = "108.177.119.91";
            Console.WriteLine($"{a}\n");

            Magazine b = new Magazine();
            b.Name = "Fortinate";
            b.Year = 2019;
            b.Description = "BattleRoyal Game";
            b.Tel = 3808593;
            b.Email = "fortnitesupport@gmail.com";
            Console.WriteLine($"{b}\n");

            Store c = new Store();
            c.Name = "City-Center";
            c.Address = "";
            c.Description = "Music: Phonk";
            c.Tel = 380574782;
            c.Email = "citucenter@gmail.com";
            Console.WriteLine($"{c}\n");
        }
    }
}
