using eGameStore.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eGameStore.Models
{
    public class Publisher : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Publisher Logo")]
        public string ProfilePictureURL { get; set; }
		[Display(Name = "Publisher Name")]
		public string FullName { get; set; }
		[Display(Name = "Biography")]
		public string Bio { get; set; }

        //Relationships
        public List<Game> Games { get; set; }
    }
}
