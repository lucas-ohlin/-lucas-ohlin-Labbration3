using Labb3EF_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Labb3EF_Final.Src {

    internal class Navigation {

        public static void Menu() {

            bool run = true;
            while (run) {

                Console.WriteLine(
                    "\n1. Display all students\r\n" +
                    "2. Display all students of a class\r\n" +
                    "3. Add new employees\r\n" 
                );

                //Choice input
                byte choice;
                if (!byte.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("\nNumber 1-3.");

                switch (choice) {
                    default: //If not a valid choice
                        Console.WriteLine("Not a valid choice.");
                        break;
                    case 1:
                        DBReading.DisplayAllStudents();
                        break;
                    case 2:
                        DBReading.DisplayClass();
                        break;
                    case 3:
                        DBAdd.DBAddStaff();
                        break;
                }

            }

        }

    }

}
