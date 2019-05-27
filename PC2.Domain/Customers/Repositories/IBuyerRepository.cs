using PC2.Domain.Customers.Entities;
using System;
using System.Collections.Generic;

namespace PC2.Domain.Customers.Repositories
{
    public interface IBuyerRepository
    {
        void Save(Buyer buyer);
        void Update(Buyer buyer);
        Buyer GetById(Guid id);
        Buyer GetByName(string id);
        IEnumerable<Buyer> List();
    }
}
