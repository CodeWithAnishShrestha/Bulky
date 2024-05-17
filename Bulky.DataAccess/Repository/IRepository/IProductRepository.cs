using BulkyBook.Models.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void update(Product obj);
    }
}