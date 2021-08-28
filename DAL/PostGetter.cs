using TaskManager.Models;

namespace TaskManager.DAL
{
    public class PostGetter : IPostGetter
    {
        private readonly IPostRepository _postRepository;

        public PostGetter(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public Post GetPost(int id)
        {
            return _postRepository.GetPost(id);
        }
    }
}
