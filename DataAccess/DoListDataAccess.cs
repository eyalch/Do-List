using System.Collections.Generic;
using System.Linq;
using To_Do_List_Project_.DataAccess;

namespace To_Do_List_Project_
{
    public class DoListDataAccess
    {
        public static List<DoListModel> List()
        {
            using (var context = new AppDBContext())
            {
                return context.DoList.ToList();
            }
        }

        public static void Add(string text)
        {
            using (var context = new AppDBContext())
            {
                var newTask = new DoListModel
                {
                    Id = context.DoList.Count() + 1,
                    Task = text
                };

                context.DoList.Add(newTask);
                context.SaveChanges();
            }
        }

        public static void Edit(int id, string newText)
        {
            using (var context = new AppDBContext())
            {
                var result = context.DoList.Find(id);
                result.Task = newText;
                context.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (var context = new AppDBContext())
            {
                var task = context.DoList.Find(id);
                context.DoList.Remove(task);
                context.SaveChanges();
            }
        }
    }
}
