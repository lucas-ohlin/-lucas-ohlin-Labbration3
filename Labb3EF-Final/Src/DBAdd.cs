using Labb3EF_Final.Models;
using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Src {

    internal class DBAdd {

        private static AppDBContext context = new AppDBContext();

        public static void DBAddStaff() {

            Console.WriteLine("\nAdding a new employee to the school:");

            Console.WriteLine("First Name:");
            string fname = Console.ReadLine();

            Console.WriteLine("Last Name:");
            string lname = Console.ReadLine();

            Person person = new Person() {
                Fname = fname,
                Lname = lname
            };

            //Add and save the person to the database
            context.People.Add(person);
            context.SaveChanges();

            Console.WriteLine("Title:");
            string title = Console.ReadLine();

            //Gets the latest added person (added by us above this)
            var getId = context.People.OrderByDescending(x => x.Id).ToList();
            staff staff = new staff() {
                StaffId = getId[0].Id,
                Title = title,
            };

            context.staff.Add(staff);
            context.SaveChanges();

            Console.WriteLine($"Added {fname + " " + lname} to the database as a {title}.");

        }

    }

}
