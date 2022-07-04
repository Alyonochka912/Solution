using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_quest;

namespace Console_quest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            for (int i = 0; i < controller.texts.Length; i++)
            {
                Console.WriteLine(controller.texts[i]);
                if (Convert.ToInt32(Console.ReadLine()) != controller.answers[i])
                {
                    Console.WriteLine(controller.death[i]);
                    break;
                }
                else
                {
                    Console.WriteLine(controller.life[i]);

                }
            }

            Console.ReadLine();
        }
    }
}
