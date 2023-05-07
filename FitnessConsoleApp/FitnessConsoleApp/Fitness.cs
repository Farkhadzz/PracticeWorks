using FitnessConsoleApp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FitnessConsoleApp
{
    public class Fitness
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome To The Console App 'ConsoleFitness'");

            Console.Write("Enter UserName : ");
            var name = Console.ReadLine();

            Console.Write("Enter Gender : ");
            var gender = Console.ReadLine();

            Console.Write("Enter BirhDay : ");
            var birthday = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Weight : ");
            var weight = double.Parse(Console.ReadLine());

            Console.Write("Enter Height : ");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthday, weight, height);
            userController.Serialize();
        }
    }
}
