using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hogwartsApi.Persistence.Contexts;
using hogwartsApi.Domain.Repositories;
using hogwartsApi.Domain.Models;

namespace hogwartsApi.Persistence.Repositories
{
    public class ApplicationRepository : BaseRepository, IApplicationRepository
    {
        public ApplicationRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Application>> ListAsync()
        {
            return await _context.Applications.ToListAsync();
        }

        public async Task AddAsync(Application application)
        {
            await _context.Applications.AddAsync(application);
        }

        public async Task<Application> FindByIdAsync(int id)
        {
            return await _context.Applications.FindAsync(id);
        }

        public void Update(Application application)
        {
            _context.Applications.Update(application);
        }

		public void Remove(Application application)
{
	_context.Applications.Remove(application);
}
    }
}
