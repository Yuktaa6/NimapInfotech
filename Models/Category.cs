using System.ComponentModel.DataAnnotations;

namespace Nimap_Infotech.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
  
    }
}


