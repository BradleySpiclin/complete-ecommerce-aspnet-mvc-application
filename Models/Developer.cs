using System.ComponentModel.DataAnnotations;

namespace eGameStore.Models
{
    public class Developer
    {
        [Key]
        public int Id { get; set; }
		[Display(Name = "Developer Logo")]
        [Required(ErrorMessage ="Profile picture required")]
		public string ProfilePictureURL { get; set; }
		[Display(Name = "Developer Name")]
        [Required(ErrorMessage = "Developer name required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full name must be between 3 - 50 characters")]
        public string FullName { get; set; }

		[Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography required")]
        public string Bio { get; set; }

        //Relationships
        public List<Game>? Games { get; set; }
    }
}
