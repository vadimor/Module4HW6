using System;
using System.Threading.Tasks;
using System.Linq;
using Module4HW6.Entity;

namespace Module4HW6.Helper
{
    public class DbDataInitializer
    {
        private ApplicationDbContext _context;
        private TransactionHelper _transactionHelper;
        public DbDataInitializer(ApplicationDbContext context, TransactionHelper transactionHelper)
        {
            _context = context;
            _transactionHelper = transactionHelper;
        }

        public async Task InitializeAsync()
        {
            await _transactionHelper.TransactionShellAsync(async () =>
            {
                if (_context.Artist.Any())
                {
                    return;
                }

                await _context.AddAsync(new Genre { Id = 1, Title = "Pop" });
                await _context.AddAsync(new Genre { Id = 2, Title = "Classic" });
                await _context.AddAsync(new Genre { Id = 3, Title = "Rock" });
                await _context.AddAsync(new Genre { Id = 4, Title = "Jazz" });
                await _context.AddAsync(new Genre { Id = 5, Title = "Blues" });
                await _context.SaveChangesAsync();
                await _context.AddAsync(new Artist { Id = 1, Name = "Maybe Baby", DateOfBirth = new DateTime(1995, 2, 5) });
                await _context.AddAsync(new Artist { Id = 2, Name = "Dora", DateOfBirth = new DateTime(1996, 4, 24) });
                await _context.AddAsync(new Artist { Id = 3, Name = "Alena Shvets", DateOfBirth = new DateTime(1993, 12, 1) });
                await _context.AddAsync(new Artist { Id = 4, Name = "Misha Gorshok", DateOfBirth = new DateTime(1978, 1, 3) });
                await _context.AddAsync(new Artist { Id = 5, Name = "Ivan Giga", DateOfBirth = new DateTime(1967, 1, 8) });
                await _context.SaveChangesAsync();
                await _context.AddAsync(new Song { Id = 1, Title = "Ahegao", Duration = "3:30", ReleasedDate = new DateTime(2021, 3, 24), GenreId = 1 });
                await _context.AddAsync(new Song { Id = 2, Title = "Vtyrilas", Duration = "2:16", ReleasedDate = new DateTime(2021, 7, 1), GenreId = 1 });
                await _context.AddAsync(new Song { Id = 3, Title = "Yavoruna", Duration = "3:10", ReleasedDate = new DateTime(1990, 2, 5), GenreId = 2 });
                await _context.AddAsync(new Song { Id = 4, Title = "Dora dura", Duration = "2:49", ReleasedDate = new DateTime(2019, 4, 11), GenreId = 1 });
                await _context.AddAsync(new Song { Id = 5, Title = "Hymn Berislava", Duration = "6:50:00", ReleasedDate = new DateTime(1955, 1, 1) });
                await _context.SaveChangesAsync();
                await _context.AddAsync(new ArtistSong { Id = 1, ArtistId = 1, SongId = 1 });
                await _context.AddAsync(new ArtistSong { Id = 2, ArtistId = 2, SongId = 2 });
                await _context.AddAsync(new ArtistSong { Id = 3, ArtistId = 5, SongId = 3 });
                await _context.AddAsync(new ArtistSong { Id = 4, ArtistId = 2, SongId = 4 });
                await _context.SaveChangesAsync();
            });
        }
    }
}
