using DoList.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do_List_Project_.DataAccess;

namespace To_Do_List_Project_
{
    public class DoListDataAccess
    {
        private static MyDBContext _db = new MyDBContext();

        public static void Watch() // Done
        {
            using (var context = new MyDBContext())
            {
                var counter = context.DoList.Count();
                Console.WriteLine($"\nYou have {counter} tasks: \n");

                var list = context.DoList.ToList();

                foreach (var item in list)
                {
                    Console.WriteLine(item.Task);
                }
            }
        }

        public static void Add() // Done
        {
            using (var context = new MyDBContext())
            {
                Console.WriteLine("\nEnter new task: ");
                var counterId = context.DoList.Count() + 1;

                var newTask = new DoListModel()
                {
                    Id = counterId,
                    Task = Console.ReadLine()
                };

                context.Add(newTask);
                context.SaveChanges();
            }
        }

        public static void Edit() // Done
        {
            using (var context = new MyDBContext())
            {
                Console.WriteLine("Id of task to change: ");
                var idOfTask = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Insert new task: ");
                var newTask = Console.ReadLine();

                var result = context.DoList.Find(idOfTask);
                result.Task = newTask;

                context.SaveChanges();
            }
        }

        public static void Delete() // Done
        {
            using (var context = new MyDBContext())
            {
                var allTasks = context.DoList.ToList();

                Console.WriteLine("Id task to delete: ");
                var idOfTask = Int32.Parse(Console.ReadLine());

                context.Remove(allTasks[idOfTask - 1]);
                context.SaveChanges();

                if (allTasks.Count() < 1)
                {
                    Console.WriteLine($"\nThere are {allTasks.Count() - 1} task left\n");
                }
                
            }
        }
    }
}
