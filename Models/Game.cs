using eGameStore.Data.Base;
using eGameStore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eGameStore.Models
{
    public class Game : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Game Title")]
        [Required(ErrorMessage = "Title required")]
        public string Name { get; set; }
        [Display(Name = "Game Description")]
        [Required(ErrorMessage = "Description required")]
        public string Description { get; set; }
        [Display(Name = "Game Price")]
        [Required(ErrorMessage = "Price required")]
        public double Price { get; set; }

        [Display(Name = "Game Image")]
        [Required(ErrorMessage = "Image required")]
        public string ImageURL { get; set; }
        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Date required")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Game Genre")]
        [Required(ErrorMessage = "Genre required")]
        public GameGenre GameGenre { get; set; }

        //Relationship with Developer
        [ForeignKey("DeveloperId")]
        public int DeveloperId { get; set; }

        [Display(Name = "Game Developer")]
        [Required(ErrorMessage = "Developer required")]
        public Developer Developer { get; set; }

		//Relationship with Publisher
		[ForeignKey("PublisherId")]
		public int PublisherId { get; set; }

        [Display(Name = "Game Publisher")]
        [Required(ErrorMessage = "Publisher required")]
        public Publisher Publisher { get; set; }

}

}
