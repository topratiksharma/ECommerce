using Catalog.Core.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Data;

public class CatalogContext : ICatalogContext
{
    public IMongoCollection<Product> Products { get; }
    public IMongoCollection<ProductBrand> Brands { get; }
    public IMongoCollection<ProductType> Types { get; }

    public CatalogContext(IConfiguration settings)
    {
        var client = new MongoClient(settings.GetValue<string>("DatabaseSettings:ConnectionString"));
        var database = client.GetDatabase(settings.GetValue<string>("DatabaseSettings:DatabaseName"));

        Brands = database.GetCollection<ProductBrand>(settings.GetValue<string>("DatabaseSettings:BrandsCollection"));
        Types = database.GetCollection<ProductType>(settings.GetValue<string>("DatabaseSettings:TypesCollection"));
        Products = database.GetCollection<Product>(settings.GetValue<string>("DatabaseSettings:ProductCollection"));

        BrandContextSeed.SeedData(Brands);
        TypeContextSeed.SeedData(Types);
        CatalogContextSeed.SeedData(Products);
    }
}