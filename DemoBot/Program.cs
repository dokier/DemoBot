using System;
using System.Collections;
using System.Threading;
using System.Text;

namespace DemoBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string demonArt = @"                               ,-.
          ___,---.__          /'|`\          __,---,___
       ,-'    \`    `-.____,-'  |  `-.____,-'    //    `-.
     ,'        |           ~'\     /`~           |        `.
    /      ___//              `. ,'          ,  , \___      \
   |    ,-'   `-.__   _         |        ,    __,-'   `-.    |
   |   /          /\_  `   .    |    ,      _/\          \   |
   \  |           \ \`-.___ \   |   / ___,-'/ /           |  /
    \  \           | `._   `\\  |  //'   _,' |           /  /
     `-.\         /'  _ `---'' , . ``---' _  `\         /,-'
        ``       /     \    ,='/ \`=.    /     \       ''
                |__   /|\_,--.,-.--,--._/|\   __|
                /  `./  \\`\ |  |  | /,//' \,'  \
               /   /     ||--+--|--+-/-|     \   \
              |   |     /'\_\_\ | /_/_/`\     |   |
               \   \__, \_     `~'     _/ .__/   /
                `-._,-'   `-._______,-'   `-._,-'
";

            string welcomeMessage = @"
          ████████▄     ▄████████   ▄▄▄▄███▄▄▄▄    ▄██████▄  ▀█████████▄   ▄██████▄      ███     
          ███   ▀███   ███    ███ ▄██▀▀▀███▀▀▀██▄ ███    ███   ███    ███ ███    ███ ▀█████████▄ 
          ███    ███   ███    █▀  ███   ███   ███ ███    ███   ███    ███ ███    ███    ▀███▀▀██ 
          ███    ███  ▄███▄▄▄     ███   ███   ███ ███    ███  ▄███▄▄▄██▀  ███    ███     ███   ▀ 
          ███    ███ ▀▀███▀▀▀     ███   ███   ███ ███    ███ ▀▀███▀▀▀██▄  ███    ███     ███     
          ███    ███   ███    █▄  ███   ███   ███ ███    ███   ███    ██▄ ███    ███     ███     
          ███   ▄███   ███    ███ ███   ███   ███ ███    ███   ███    ███ ███    ███     ███     
          ████████▀    ██████████  ▀█   ███   █▀   ▀██████▀  ▄█████████▀   ▀██████▀     ▄████▀   
                                                                                                 
";

            string pickdemon_Label = @"
╔═╗┌─┐┌─┐┬─┐┌─┐┬ ┬┬┌┐┌┌─┐  ┬ ┬┌─┐┬  ┬        
╚═╗├┤ ├─┤├┬┘│  ├─┤│││││ ┬  ├─┤├┤ │  │        
╚═╝└─┘┴ ┴┴└─└─┘┴ ┴┴┘└┘└─┘  ┴ ┴└─┘┴─┘┴─┘      
┌─┐┌─┐┬─┐  ┌─┐┌┐┌  ┌─┐┬  ┬┌─┐┬┬  ┌─┐┌┐ ┬  ┌─┐
├┤ │ │├┬┘  ├─┤│││  ├─┤└┐┌┘├─┤││  ├─┤├┴┐│  ├┤ 
└  └─┘┴└─  ┴ ┴┘└┘  ┴ ┴ └┘ ┴ ┴┴┴─┘┴ ┴└─┘┴─┘└─┘
┌┬┐┌─┐┌┬┐┌─┐┌┐┌           ┬                  
 ││├┤ ││││ ││││           │                  
─┴┘└─┘┴ ┴└─┘┘└┘  o  o  o  o                  
";
            string questionLabel = @"
╔═╗┌─┐┬┌─  ┌─┐  ┌─┐ ┬ ┬┌─┐┌─┐┌┬┐┬┌─┐┌┐┌        ┬
╠═╣└─┐├┴┐  ├─┤  │─┼┐│ │├┤ └─┐ │ ││ ││││        │
╩ ╩└─┘┴ ┴  ┴ ┴  └─┘└└─┘└─┘└─┘ ┴ ┴└─┘┘└┘  o  o  o
";

            Hashtable answerList = new Hashtable();
            answerList.Add(1, "Don't feel like answering that..");
            answerList.Add(2, "I don't know.... and I don't care");
            answerList.Add(3, "Don't push it...! You don't know who you're messing with");
            answerList.Add(4, "You already know the answer..");
            answerList.Add(5, "I'm coming for you tonight....");
            answerList.Add(6, "You're stupid....");
            answerList.Add(7, "Not sure if I want to talk to you anymore...");
            answerList.Add(8, "You're making me angry... probably not a good thing...");
            answerList.Add(9, "Really? You gotta be kidding me....");
            answerList.Add(10, "You're full of bullshit...");

            Hashtable demonList = new Hashtable();
            demonList.Add(1, "Magmaz");
            demonList.Add(2, "Baggannok");
            demonList.Add(3, "Sangroth");
            demonList.Add(4, "Ragezar");
            demonList.Add(5, "Mannakath");
            demonList.Add(6, "Agmen");
            demonList.Add(7, "Urgrith");
            demonList.Add(8, "Gostrath");
            demonList.Add(9, "Al'guran");
            demonList.Add(10, "Ar'gonnath");

            string questionString = "I would like to know";


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(welcomeMessage);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t Play at your own risk..!");

            Console.Write("\t Press Enter to continue.....");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(pickdemon_Label);
            Console.WriteLine();

            Random rnd = new Random();
            int rndKey = rnd.Next(1, 10);
            /*
            foreach (DictionaryEntry demon in demonList)
            {
                Console.WriteLine("{0} - {1}", demon.Key, demon.Value);
            }
            */
            ConsoleSpiner spin = new ConsoleSpiner();
            Console.ResetColor();
            Console.Write("Searching....");
            int i = 0;
            while (i < 40)
            {
                spin.Turn();
                i++;
                Thread.Sleep(100);
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("{0}", demonList[rndKey]);
            Console.ResetColor();
            Console.Write(" is available to talk..");
            Console.WriteLine();
            Console.Write("Press Enter to continue.....");
            Console.ResetColor();

            Console.ReadLine();
            Console.Clear();

            while (true)
            {
                StringBuilder input = new StringBuilder();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(demonArt);
                Console.WriteLine(questionLabel);
                Console.ResetColor();
                Console.Write("Question: ");
                var startKey = Console.ReadKey(true);

                if (startKey.Key == ConsoleKey.OemPeriod)
                {
                    foreach (char c in questionString)
                    {
                        var stopKey = Console.ReadKey(true);
                        if (stopKey.Key == ConsoleKey.OemPeriod) break;
                        //if (stopKey.Key == ConsoleKey.Backspace && input.Length > 0) Console.Write("\b");//input.Remove(input.Length - 1, 1);
                        //else if (key.Key != ConsoleKey.Backspace) 
                        input.Append(stopKey.KeyChar);

                        Console.Write(c);
                    }
                    Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("{0}", demonList[rndKey]);
                    Console.ResetColor();
                    Console.Write(" says: ");
                    int j = 0;
                    while (j < 40)
                    {
                        spin.Turn();
                        j++;
                        Thread.Sleep(100);
                    }
                    Console.Write("{0}", input.ToString());
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Write(startKey.KeyChar);

                    Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("{0}", demonList[rndKey]);
                    Console.ResetColor();
                    Console.Write(" says: ");
                    int k = 0;
                    while (k < 40)
                    {
                        spin.Turn();
                        k++;
                        Thread.Sleep(100);
                    }
                    Random rndSeed = new Random();
                    int rndAnswer = rndSeed.Next(1, 10);
                    Console.Write("{0}", answerList[rndAnswer]);
                    Console.ReadLine();
                    Console.Clear();
                }

            }

        }

        public class ConsoleSpiner
        {
            int counter;
            public ConsoleSpiner()
            {
                counter = 0;
            }
            public void Turn()
            {
                counter++;
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
}
