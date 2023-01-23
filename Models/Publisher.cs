using eGameStore.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eGameStore.Models
{
    public class Publisher : IEntityBase //inherits from the base interface
    {
		[Key]
		public int Id { get; set; }
		[Display(Name = "Publisher Logo")]
		[Required(ErrorMessage = "Profile picture required")]
		public string ProfilePictureURL { get; set; }
		[Display(Name = "Publisher Name")]
		[Required(ErrorMessage = "Publisher name required")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 - 50 characters")]
		public string FullName { get; set; }

		[Display(Name = "Biography")]
		[Required(ErrorMessage = "Biography required")]
		public string Bio { get; set; }

		//Relationships
		public List<Game>? Games { get; set; }
	}
}
