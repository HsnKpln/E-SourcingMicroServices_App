using E_SourcingMicroServices.Entities;
using MongoDB.Driver;

namespace E_SourcingMicroServices.Data.Interfaces
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
