using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.EF
{
    public interface IExamSystemDbContext
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
