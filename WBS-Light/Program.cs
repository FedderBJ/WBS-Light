using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS_Light
{
    class Program
    {
        static public void InitScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WindowHeight = 15;
            Console.WindowWidth = 19;
        }

        static public void FirstScreen()
        {
            Console.WriteLine(string.Format("Udlevering         "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("Tast / Scan        "));
            Console.WriteLine(string.Format("Kundenummer        "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("                   "));
            Console.WriteLine(string.Format("-(balance.as)-(050)"));
            Console.SetCursorPosition(0, 5);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            InitScreen();
            FirstScreen();
            
            
        }
    }
}
