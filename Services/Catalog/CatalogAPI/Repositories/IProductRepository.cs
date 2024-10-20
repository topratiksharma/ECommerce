using CatalogAPI.Entities;

namespace CatalogAPI.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(string id);
        Task<Product> GetProductByName(string name);
        Task<Product> GetProductByBrand(string brandName);
        Task<Product> CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string id);
    }
}
