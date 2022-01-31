using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entity;

namespace Module4HW6.Configuration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Title).IsRequired();
        }
    }
}
