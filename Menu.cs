﻿using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    class Menu
    {
        private static List<MenuItem> MenuItems;

        public static void PopulateMenuItems()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem {Description = "Edit product and prices list", Execute = EditProductAndPricesList},
                new MenuItem {Description = "Edit promotions", Execute = EditPromotions},
                new MenuItem {Description = "Edit customer basket", Execute = EditCustomerBasket},
                new MenuItem {Description = "Calculate customer basket", Execute = CalculateCustomerBasket},
                new MenuItem {Description = "Exit", Execute = Exit},
            };
        }

        public static void MainMenu()
        {
            ClearAndShowHeading("Main Menu");

            Console.CursorVisible = false;
            while (true)
            {
                int selectedMenuItem = DrawMainMenu();
                MenuItems[selectedMenuItem - 1].Execute();
            }
        }

        public static int DrawMainMenu()
        {
            for (int index = 0; index < MenuItems.Count; index++)
            {
                Console.WriteLine($" {index + 1}. {MenuItems[index].Description}");
            }

            int cursorTop = Console.CursorTop + 1;
            int userInput = 0;

            do
            {
                Console.SetCursorPosition(0, cursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, cursorTop);
                Console.Write($"Enter a choice (1 - {MenuItems.Count}): ");
            } while (!int.TryParse(Console.ReadLine(), out userInput) ||
                     userInput < 1 || MenuItems.Count < userInput);

            return userInput;
        }

        private static void ClearAndShowHeading(string heading)
        {
            Console.Clear();
            Console.WriteLine(heading);
            Console.WriteLine(new string('-', heading?.Length ?? 0));
        }

        private static void ReturnToMainMenu()
        {
            Console.WriteLine("Press a key to continue to the main menu...");
            Console.CursorVisible = false;
            Console.ReadKey();
            MainMenu();
        }

        private static void EditProductAndPricesList()
        {
            ClearAndShowHeading("Edit product and prices list");
            ReturnToMainMenu();
        }

        private static void EditPromotions()
        {
            ClearAndShowHeading("Edit promotions");
            ReturnToMainMenu();
        }

        private static void EditCustomerBasket()
        {
            ClearAndShowHeading("Edit customer basket");
            ReturnToMainMenu();
        }

        private static void CalculateCustomerBasket()
        {
            ClearAndShowHeading("Calculate customer basket");
            ReturnToMainMenu();
        }

        private static void Exit()
        {
            ClearAndShowHeading("Exit");
            Console.WriteLine("Exiting program.");
            System.Environment.Exit(0);  // or Environment.Exit(0);
        }
    }
}