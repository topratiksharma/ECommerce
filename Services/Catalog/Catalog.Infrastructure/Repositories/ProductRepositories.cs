using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;

namespace Catalog.Infrastructure.Repositories
{
    public class ProductRepositories: IProductRepository, IBrandRepository, ITypeRepository
    {
        public ICatalogContext _context;

        public ProductRepositories(ICatalogContext context)
        {
            _context = context;
        }

        Task<Product> IProductRepository.CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        Task<bool> IProductRepository.DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<ProductType>> ITypeRepository.GetAllTypes()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<ProductBrand>> IBrandRepository.GetBrands()
        {
            throw new NotImplementedException();
        }

        Task<Product> IProductRepository.GetProduct(string id)
        {
            throw new NotImplementedException();
        }

        Task<Product> IProductRepository.GetProductByBrand(string brandName)
        {
            throw new NotImplementedException();
        }

        Task<Product> IProductRepository.GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IProductRepository.GetProducts()
        {
            throw new NotImplementedException();
        }

        Task<bool> IProductRepository.UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
