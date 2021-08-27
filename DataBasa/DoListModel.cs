using System.ComponentModel.DataAnnotations;

namespace To_Do_List_Project_
{
    public class DoListModel
    {
        public int Id { get; set; }

        [Required]
        public string Task { get; set; }
    }
}
