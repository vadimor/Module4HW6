using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entity;

namespace Module4HW6.Configuration
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.ReleasedDate).IsRequired();
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Duration).IsRequired();
        }
    }
}
