﻿using System;

namespace stih
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Корова и лошадь");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Корова не похожа на лошадь");
            Console.WriteLine("Лошадь не похожа на корову");
            Console.WriteLine("Именно это сходство");
            Console.WriteLine("Мы и берем за основу");

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
