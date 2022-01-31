using System;
using System.Collections.Generic;

namespace Module4HW6.Entity
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public List<ArtistSong> ArtistSongs { get; set; } = new List<ArtistSong>();
    }
}
