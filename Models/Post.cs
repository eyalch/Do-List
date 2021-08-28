using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
