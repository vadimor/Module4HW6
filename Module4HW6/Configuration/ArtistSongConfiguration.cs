using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entity;

namespace Module4HW6.Configuration
{
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(h => h.Id).ValueGeneratedNever();
            builder.Property(p => p.ArtistId).IsRequired();
            builder.Property(p => p.SongId).IsRequired();
            builder.HasOne(h => h.Artist)
                .WithMany(w => w.ArtistSongs)
                .HasForeignKey(h => h.ArtistId);
            builder.HasOne(h => h.Song)
                .WithMany(w => w.ArtistSongs)
                .HasForeignKey(h => h.SongId);
        }
    }
}
