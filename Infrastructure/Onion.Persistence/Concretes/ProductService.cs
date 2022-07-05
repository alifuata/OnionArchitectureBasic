using Onion.Application.Abstractions;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => new()
        {
            new(){ID=Guid.NewGuid(),Name="Bread",Price=1.2,Stock=100},
            new(){ID=Guid.NewGuid(),Name="Cola",Price=0.2,Stock=10},
            new(){ID=Guid.NewGuid(),Name="Meat",Price=16.2,Stock=100},
            new(){ID=Guid.NewGuid(),Name="Toy",Price=12.0,Stock=15},
            new(){ID=Guid.NewGuid(),Name="Onion",Price=0.1,Stock=125},
            new(){ID=Guid.NewGuid(),Name="Tomatoes",Price=0.6,Stock=155}
        };
    }
}
