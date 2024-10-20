using CatalogAPI.Entities;

namespace CatalogAPI.Repositories
{
    public interface ITypesRepository
    {
        Task<IEnumerable<ProductType>> GetAllTypes();
    }
}
