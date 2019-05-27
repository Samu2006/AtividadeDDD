using PC2.Domain.Concessionaire.Entities;
using System;
using System.Collections.Generic;

namespace PC2.Domain.Concessionaire.Repositories
{
    public interface IVehicleSalesRepository
    {
        void Save(VehicleSales vehicleSales);
        void Update(VehicleSales vehicleSales);
        VehicleSales GetById(Guid id);
        IEnumerable<VehicleSales> List();
    }
}
