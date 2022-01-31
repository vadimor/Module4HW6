using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module4HW6.Entity;

namespace Module4HW6.Helper
{
    public class Requests
    {
        private readonly ApplicationDbContext _context;
        private readonly TransactionHelper _transaction;

        public Requests(ApplicationDbContext context, TransactionHelper transactionHelper)
        {
            _context = context;
            _transaction = transactionHelper;
        }

        public async Task<IReadOnlyList<Song>> FirstRequestAsync()
        {
            return await _context.Song.Include(i => i.Genre).Include(i => i.ArtistSongs).Where(w => w.Genre != null && w.ArtistSongs != null).ToListAsync();
        }

        public async Task<IReadOnlyList<string>> SecondRequestAsync()
        {
            return await _context.Genre.Include(i => i.Songs).Select(i => $"{i.Title} have {i.Songs.Count} songs").ToListAsync();
        }

        public async Task<IReadOnlyList<Song>> ThirdRequestAsync()
        {
            var maxDate = await _context.Artist.MaxAsync(m => m.DateOfBirth);
            return await _context.Song.Where(w => w.ReleasedDate < maxDate).ToListAsync();
        }
    }
}
