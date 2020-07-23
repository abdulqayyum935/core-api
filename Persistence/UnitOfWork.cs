using System.Threading.Tasks;
using api_db.Core.IRepositories;

namespace api_db.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext context;
        public UnitOfWork(DatabaseContext context){
            this.context=context;
        }
        public async Task SaveChangesAsync() => await this.context.SaveChangesAsync();
    }
}