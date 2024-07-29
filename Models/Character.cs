using System.ComponentModel.DataAnnotations;

namespace UniverseRepo.Models
{
    public class Character
    {

        public int Id { get; set; }
        public string character_Name { get; set; } 
        public string universe_Name { get; set;}
        public string description { get; set;}
    }
}
