using System.Collections.Generic;
using System.Threading.Tasks;
using hogwartsApi.Domain.Models;
using hogwartsApi.Domain.Services.Communication;

namespace hogwartsApi.Domain.Services
{
    public interface IApplicationService
    {
        Task<IEnumerable<Application>> ListAsync();
        Task<ApplicationResponse> SaveAsync(Application application);
        Task<ApplicationResponse> UpdateAsync(int id, Application application);
        Task<ApplicationResponse> DeleteAsync(int id);
    }
}


