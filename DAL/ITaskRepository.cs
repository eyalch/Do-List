using System;
using System.Collections.Generic;
using To_Do_List_Project_;

namespace DoList.DAL
{
    public interface ITaskRepository : IDisposable
    {
        List<DoListModel> GetTasks();
        void AddTask(DoListModel task);
        void UpdateTask(DoListModel task);
        void DeleteTask(int taskId);
        void Save();
    }
}
