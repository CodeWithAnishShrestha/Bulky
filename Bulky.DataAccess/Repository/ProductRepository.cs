using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using BulkyBook.Models.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}