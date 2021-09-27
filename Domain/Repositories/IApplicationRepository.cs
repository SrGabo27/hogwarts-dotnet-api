using System.Collections.Generic;
using System.Threading.Tasks;
using hogwartsApi.Domain.Models;

namespace hogwartsApi.Domain.Repositories
{
    public interface IApplicationRepository
    {
        Task<IEnumerable<Application>> ListAsync();
        Task AddAsync(Application application);
        Task<Application> FindByIdAsync(int id);
        void Update(Application application);
		void Remove(Application application);
    }
}
