using _01BasOffDL.Context;
using _01BasOffEL.Entities;
using _02BasOffBL.Repo;
using Microsoft.EntityFrameworkCore;

namespace _01BasOffDL.Repo
{
    public class GenericRepo<T> : IGenericRepo<T> where T : BaseEntity
    {
        private MyDBContext _context;
        private DbSet<T> _dbSet;
        public GenericRepo(MyDBContext context) {
            _context = context; 
            _dbSet = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            try
            {
                return _dbSet;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<T> Get(int id)
        {
            try
            {
                return await _dbSet.FirstOrDefaultAsync(s => s.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
