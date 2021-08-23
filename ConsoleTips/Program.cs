﻿using ConsoleTips.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleTips
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInput.Clear();
            System.Console.WriteLine("Intro to C# with Command Line\n\nIf you wish to end the application then enter E at any time.\n\nPlease Press any key to continue.\n\nCreated by: Daniel Aguirre");
            ConsoleHandler.ReadAndClear();
            IPage menuPage = new Menu();
            Router.Go(menuPage);
            menuPage.ProcessUserInput();
            
            //while (ConsoleHandler.programActive)
            //{
            //    ConsoleInput.Clear();
            //    // Ask user which commands to display, then show commands upon completion.
            //    ConsoleHandler.GetInput();
            //    // wait for Console.ReadKey() then will Console.Clear()
            //    ConsoleHandler.ReadAndClear();
            //    // Offer new command list, if user inputs no then will end program.
            //    ConsoleHandler.OfferNewCommandList();
            //};
        }

        
    }
}
