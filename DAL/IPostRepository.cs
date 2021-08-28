using System;
using System.Collections.Generic;
using TaskManager.Models;

namespace TaskManager.DAL
{
    public interface IPostRepository : IDisposable
    {
        List<Post> GetPosts();
        Post GetPost(int id);
        void AddPost(Post post);
        void Save();
    }
}
