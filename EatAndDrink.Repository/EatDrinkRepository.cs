using System.Threading.Tasks;
using EatAndDrink.Domain.Entities;
using EatAndDrink.Repository.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EatAndDrink.Repository
{

    public class EatDrinkRepository : IEatDrinkRepository
    {
        private readonly EDContext _context;
        public EatDrinkRepository(EDContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.AddAsync(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Detele<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }


        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Product[]> GetAllProducts()
        {
            IQueryable<Product> products = _context.Products
             .Include(u => u.UnitMeasures)
             .Include(c => c.Category)
             .ThenInclude(s => s.SubCategory);


            products = products.AsNoTracking()
            .OrderBy(s => s.Name);

            return await products.ToArrayAsync();
        }
    }
}
