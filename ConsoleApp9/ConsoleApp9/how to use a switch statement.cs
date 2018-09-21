using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the damage calculator!");
            float hp = 1000;            
            Console.WriteLine("the chicken has" + hp + "hp");
            Console.WriteLine("please enter damage:");
            float damage = float.Parse(Console.ReadLine());

            if (damage >= hp)
            {
                Console.WriteLine("the chicken is dead!");
                if (damage >= (2 * hp))// multiply the hp by 2
                    Console.WriteLine("it was over kill !");

                Console.WriteLine("the chicken is taunting the people! enter a number from 1 to 5 to hear a chant");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1": Console.WriteLine("i peck on people with my beak!");
                        break;
                    case "2":
                        Console.WriteLine("cock a doooooodleee dooooo!");
                        break;
                    case "3":
                        Console.WriteLine("i want you human!");
                        break;
                    case "4":
                        Console.WriteLine("i will stab you with my knives of fury!");
                        break;
                    case "5":
                        Console.WriteLine("yuummmmmmmmmyyyyy");
                        break;
                    default:
                        Console.WriteLine("it appears you dont have a number from 1 to 5, GOODBYE!");
                        break;
                        // how to use switches to assign to button reactions in game


                }

            }           
            
        }
    }
}
