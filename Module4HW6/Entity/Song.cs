using System;
using System.Collections.Generic;

namespace Module4HW6.Entity
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int? GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<ArtistSong> ArtistSongs { get; set; } = new List<ArtistSong>();
    }
}
