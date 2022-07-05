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
            int count = 0;
            Controller controller = new Controller();
            for (int i = 0; i < controller.texts.Length; i++)
            {
                Console.WriteLine(controller.texts[i]);
                if (Convert.ToInt32(Console.ReadLine()) != controller.answers[i])
                {
                    Console.WriteLine(controller.death[i]);
                    Console.WriteLine("Упс.. Не судьба! Так и будешь утопать в одиночестве!");
                    break;
                }
                else
                {
                    count++;
                    Console.WriteLine(controller.life[i]);
                    if(count == controller.answers.Length)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Вау! Супер! Теперь ты познакомился со всеми соседями, и у тебя много друзей!");
                        Console.WriteLine("P.s: ты продул в покер))");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
