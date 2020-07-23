using System.Threading.Tasks;

namespace api_db.Core.IRepositories
{
    public interface IUnitOfWork
    {
    Task SaveChangesAsync();
    }
}