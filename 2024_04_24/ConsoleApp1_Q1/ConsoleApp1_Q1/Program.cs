using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            /*animals.Add(new Lion());
            animals.Add(new Tiger());
            animals.Add(new Elephant());*/

           



            while (true)
            {
                Console.WriteLine("Enter a number:");
                Console.WriteLine("1. Lion");
                Console.WriteLine("2. Tiger");
                Console.WriteLine("3. Elephant");
                Console.WriteLine("4. Break");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    animals.Add(new Lion());
                    Console.WriteLine("Lion added to the Zoo!");
                }
                else if(input == "2")
                {
                    animals.Add(new Tiger());
                    Console.WriteLine("Tiger added to the Zoo!");
                }
                else if(input == "3")
                {
                    animals.Add (new Elephant());
                    Console.WriteLine("E added to the Zoo!");
                }
                else if(input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Inpute!");
                }
            }

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadLine();

        }
    }

    abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Lion:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Mew mew ");
        }

    }
    class Tiger:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Moooove ");
        }

    }
    class Elephant:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Whof Whof ");
        }

    }
}
