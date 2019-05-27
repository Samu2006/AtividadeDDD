using PC2.Domain.Concessionaire.Entities;
using System;
using System.Collections.Generic;

namespace PC2.Domain.Concessionaire.Repositories
{
    public interface IVehicleRepository
    {
        void Save(Vehicle vehicle);
        void Update(Vehicle vehicle);
        Vehicle GetById(Guid id);
        Vehicle GetByName(string id);
        IEnumerable<Vehicle> List();
        IEnumerable<Vehicle> List2();
        IEnumerable<Vehicle> ListByM(Guid id);
        IEnumerable<Vehicle> ListByModel(Guid model);
    }
}
