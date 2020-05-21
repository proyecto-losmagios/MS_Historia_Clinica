using MS.HC.Domain.Commands;
using MSHCAccesData;
using System.Linq;

namespace Template.AccessData.Commands
{
    public class GenericsRepository : IGenericsRepository
    {
        private readonly HCTemplateContext  _context;
        public GenericsRepository (HCTemplateContext dbContext)
        {
            _context = dbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }

        public T FindById<T>(int id) where T : class
        {
            return _context.Set<T>().Find(id);
        }

    }


}
