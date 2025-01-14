using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FragranticaRazor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 500, ErrorMessage = "Display Order must be between 1-500")]
        public int DisplayOrder { get; set; }
    }
}
