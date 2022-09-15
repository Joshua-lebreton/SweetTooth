using System.ComponentModel.DataAnnotations;

namespace SweetTooth.Models
{
    public class Category
    {
        //all primary key fields should be called ID or the class name followed by Id (CategoryId)
        [Required]
        public int CategoryId { get; set; }

        public string Name { get; set; }

    }
}
