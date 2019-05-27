using PC2.Domain.Shared.Entities;
using System;
using System.Collections.Generic;

namespace PC2.Domain.Shared.Repositories
{
    public interface IAddressRepository
    {
        void Save(Address address);
        void Update(Address address);
        Address GetById(Guid id);
        Address GetByCEP(string cep);
        IEnumerable<Address> List();
    }
}
