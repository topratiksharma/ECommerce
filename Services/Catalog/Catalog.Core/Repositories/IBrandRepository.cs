using Catalog.Core.Entities;

namespace Catalog.Core.Repositories
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
