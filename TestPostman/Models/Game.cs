using System.ComponentModel.DataAnnotations;

namespace TestPostman.Models
{
    public class Game
    {
        [Required, Key]
        public string City { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
    }
}