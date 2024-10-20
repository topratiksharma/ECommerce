using System.Text.Json;
using MongoDB.Driver;
using CatalogAPI.Entities;
using MongoDB.Bson;
using MongoDB.Bson.IO;

namespace Catalog.Infrastructure.Data
{
    public class BrandContextSeed
    {
        public static void SeedData(IMongoCollection<ProductBrand> brandCollection)
        {
            bool existProductBrand = brandCollection.Find(p => true).Any();
            string path = Path.Combine("Data", "SeedData", "brands.json");
            if (!existProductBrand)
            {
                var brandsData = File.ReadAllText(path);
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                if (brands != null)
                {
                    foreach ( var brand in brands)
                    {
                        brandCollection.InsertOneAsync(brand);
                    }
                }
            }
        }
    }
}
