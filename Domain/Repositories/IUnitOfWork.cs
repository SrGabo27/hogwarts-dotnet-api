using System.Threading.Tasks;

namespace hogwartsApi.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
