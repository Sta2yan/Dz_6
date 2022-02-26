using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userAge;
            string userWork;

            Console.Write("Как вас зовут? ");
            userName = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            userAge = Console.ReadLine();
            Console.Write("Кем вы работаете? ");
            userWork = Console.ReadLine();

            Console.WriteLine($"\nВас зовут {userName}" +
                              $"\nВам {userAge} года" +
                              $"\nВы работаете {userWork}");
        }
    }
}