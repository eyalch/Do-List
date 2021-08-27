using System;
using System.Linq;
using DoList;
using DoList.Utilities;
using Microsoft.Data.SqlClient;

namespace To_Do_List_Project_
{
    class Program
    {
        static void Main(string[] args)
        {
            var appSettings = new AppSettings();

            if (!IsServerConnected(appSettings.ConnectionString))
            {
                throw new Exception("Could not connect to the database");
            }

            while (true)
            {
                MyDisplay.Menu();

                Console.WriteLine("Choose Your Option: ");
                var option = Console.ReadLine();

                if (option.Equals(0))
                    break;

                try
                {
                    switch (option)
                    {
                        case "1":
                            {
                                var items = DoListDataAccess.List();
                                Console.WriteLine(items.Select(item => item.Task));
                            }
                            break;

                        case "2":
                            {
                                Console.WriteLine("\nEnter new task: ");
                                var text = Console.ReadLine();
                                DoListDataAccess.Add(text);
                            }
                            break;

                        case "3":
                            {
                                Console.WriteLine("Id of task to change: ");
                                var id = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("Insert new task: ");
                                var newText = Console.ReadLine();

                                DoListDataAccess.Edit(id, newText);
                            }
                            break;

                        case "4":
                            {
                                Console.WriteLine("Id task to delete: ");
                                var id = Int32.Parse(Console.ReadLine());

                                DoListDataAccess.Delete(id);
                            }
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
