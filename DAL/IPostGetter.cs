using TaskManager.Models;

namespace TaskManager.DAL
{
    public interface IPostGetter
    {
        Post GetPost(int id);
    }
}
