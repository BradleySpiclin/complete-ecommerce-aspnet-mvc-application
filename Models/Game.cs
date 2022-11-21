using eGameStore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

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
        public int DeveloperId { get; set; }
        [ForeignKey("DeveloperId")]
        public Developer Developer { get; set; }

        //Relationship with Publisher
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }

    }
}
