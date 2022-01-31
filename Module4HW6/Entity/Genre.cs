using System.Collections.Generic;

namespace Module4HW6.Entity
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
