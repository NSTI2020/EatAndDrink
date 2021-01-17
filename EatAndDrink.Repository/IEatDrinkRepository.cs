using System.Threading.Tasks;
using EatAndDrink.Domain.Entities;

namespace EatAndDrink.Repository
{
    public interface IEatDrinkRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Detele<T>(T entity) where T : class;
        Task<Product[]> GetAllProducts();
        Task<bool> SaveChanges();
    }
}
