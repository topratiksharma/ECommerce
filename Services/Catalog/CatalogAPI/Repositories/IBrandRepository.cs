using CatalogAPI.Entities;

namespace CatalogAPI.Repositories
{
    public interface IBrandRepository
    {
        Task<IEnumerable<ProductBrand>> GetBrands();
        //Task<ProductBrand> GetBrand(string id);
        //Task<ProductBrand> CreateBrand(ProductBrand brand);
        //Task<bool> UpdateBrand(ProductBrand brand);
        //Task<bool> DeleteBrand(string id);
    }
}
