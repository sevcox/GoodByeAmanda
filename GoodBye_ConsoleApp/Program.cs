﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBye_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI ui = new ProgramUI();
            ui.Run();
            Console.ReadKey();
        }
    }
}
