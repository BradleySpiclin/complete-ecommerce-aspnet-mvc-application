using System.ComponentModel.DataAnnotations;

namespace eGameStore.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Game> Games { get; set; }
    }
}
