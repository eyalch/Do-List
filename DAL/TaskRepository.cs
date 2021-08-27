using System.Collections.Generic;
using System.Linq;
using To_Do_List_Project_;
using To_Do_List_Project_.DataAccess;

namespace DoList.DAL
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDBContext context;

        public TaskRepository(AppDBContext context)
        {
            this.context = context;
        }

        public List<DoListModel> GetTasks()
        {
            return context.DoList.ToList();
        }

        public void AddTask(DoListModel task)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTask(DoListModel task)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTask(int taskId)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}
