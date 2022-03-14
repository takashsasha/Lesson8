using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Properties.Settings.Default.Welcome}");
            if (Properties.Settings.Default.userName != null)
            {
                Console.WriteLine($"\nИмя пользователя:       {Properties.Settings.Default.userName}");
                Console.WriteLine($"Возраст пользователя:   {Properties.Settings.Default.userAge}");
                Console.WriteLine($"Профессия пользователя: {Properties.Settings.Default.userProfesson}");
            }

            Console.WriteLine("\nВведите имя пользователя");
            Properties.Settings.Default.userName = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя");
            Properties.Settings.Default.userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите профессию пользователя");
            Properties.Settings.Default.userProfesson = Console.ReadLine();
            Properties.Settings.Default.Save();
            Console.ReadKey();
        }
    }
}
