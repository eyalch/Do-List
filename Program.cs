using DoList.Utilities;
using System;

namespace To_Do_List_Project_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MyDisplay.Menu();

                Console.WriteLine("Choose your option: ");
                var option = Console.ReadLine();

                if (option.Equals(0))
                    break;

                try
                {
                    switch (option)
                    {
                        case "1":
                            DoListDataAccess.Watch();
                            break;

                        case "2":
                            DoListDataAccess.Add();
                            break;

                        case "3":
                            DoListDataAccess.Edit();
                            break;

                        case "4":
                            DoListDataAccess.Delete();
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }
    }
}
