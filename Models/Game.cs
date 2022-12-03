using eGameStore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eGameStore.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime ReleaseDate { get; set; }

        public GameGenre GameGenre { get; set; }

		//Relationship with Developer
		[ForeignKey("DeveloperId")]
		public int DeveloperId { get; set; }
        public Developer Developer { get; set; }

		//Relationship with Publisher
		[ForeignKey("PublisherId")]
		public int PublisherId { get; set; }
    
        public Publisher Publisher { get; set; }

    }
}
