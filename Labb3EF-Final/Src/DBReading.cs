using Labb3EF_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb3EF_Final.Src {

    internal class DBReading {

        private static AppDBContext context = new AppDBContext();

        public static void DisplayClass() {

            //First chooses the first element of a sequence (if there are duplicates it only chooses the first instance of it)
            var classes = context.VwStudentInformations.GroupBy(x => x.Class).Select(j => j.First()).ToList();

            Console.WriteLine("Current Classes:");
            for (int i = 0; i < classes.Count; i++) 
                Console.WriteLine($"{i} | Class name : {classes[i].Class}"); 
            
            bool run = true;
            do {
                Console.WriteLine($"\nSelect which class to print : (0-{classes.Count - 1}) | Quit with ({classes.Count + 1}+)");

                byte choice;
                if (!byte.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine($"\nNumber 0-{classes.Count}.");

                if (classes.ElementAtOrDefault(choice) == null) {
                    Console.WriteLine("Not a valid class index, quitting back to main menu.");
                    run = false;
                }  
                if (classes.ElementAtOrDefault(choice) != null) {
                    //Makes a lists of all students in the choosen class
                    var students = context.VwStudentInformations.OrderBy(x => x.Fname).Where(x => x.Class == classes[choice].Class).ToList();

                    foreach (VwStudentInformation student in students)
                        Console.WriteLine($"ID : {student.Id} | Class: {student.Class} | Name : {student.Fname + " " + student.Lname} | SSN : {student.PersonNumber}");
                }

            } while(run);

        }

        public static void DisplayAllStudents() {

            Console.WriteLine(
                "\n1. Sort by first name | decending\r\n" +
                "2. Sort by first name | ascending\r\n" +
                "3. Sort by last name  | decending\r\n" +
                "4. Sort by last name  | ascending\r\n"
            );

            byte choice;
            if (!byte.TryParse(Console.ReadLine(), out choice))
                Console.WriteLine("\nNumber 1-4.");

            switch (choice) {
                default: //If not a valid choice
                    Console.WriteLine("Not a valid choice.");
                    break;
                case 1:
                    FirstNameDecending();
                    break;
                case 2:
                    FirstNameAscending();
                    break;
                case 3:
                    LastNameDecending();
                    break;
                case 4:
                    LastNameAscending();
                    break;
            }

        }

        private static void FirstNameDecending() {
            var students = context.VwStudentInformations.OrderByDescending(x => x.Fname).ToList();

            foreach (VwStudentInformation student in students)
                Console.WriteLine($"ID : {student.Id} | Class: {student.Class} | Name : {student.Fname + " " + student.Lname} | SSN : {student.PersonNumber}");
        }

        private static void FirstNameAscending() {
            var students = context.VwStudentInformations.OrderBy(x => x.Fname).ToList();

            foreach (VwStudentInformation student in students)
                Console.WriteLine($"ID : {student.Id} | Class: {student.Class} | Name : {student.Fname + " " + student.Lname} | SSN : {student.PersonNumber}");
        }

        private static void LastNameDecending() {
            var students = context.VwStudentInformations.OrderByDescending(x => x.Lname).ToList();

            foreach (VwStudentInformation student in students)
                Console.WriteLine($"ID : {student.Id} | Class: {student.Class} | Name : {student.Fname + " " + student.Lname} | SSN : {student.PersonNumber}");
        }

        private static void LastNameAscending() {
            var students = context.VwStudentInformations.OrderBy(x => x.Lname).ToList();

            foreach (VwStudentInformation student in students)
                Console.WriteLine($"ID : {student.Id} | Class: {student.Class} | Name : {student.Fname + " " + student.Lname} | SSN : {student.PersonNumber}");
        }

    }

}
