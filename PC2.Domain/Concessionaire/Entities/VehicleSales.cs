using FluentValidator;
using PC2.Domain.Customers.Entities;
using PC2.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC2.Domain.Concessionaire.Entities
{
    public class VehicleSales : Entity
    {
        public VehicleSales()
        {

        }

        public VehicleSales(Vehicle vehicle, string note, decimal inputPrice, Buyer buyer,
            DateTime inputDate, Guid licensePlate)
        {
            Vehicle = vehicle;
            Note = note;
            InputPrice = inputPrice;
            Buyer = buyer;
            InputDate = inputDate;
            LicensePlate = licensePlate;
            new ValidationContract<VehicleSales>(this);
        }
        public VehicleSales(Guid id, Vehicle vehicle, string note, decimal inputPrice, Buyer buyer,
            DateTime inputDate, Guid licensePlate, DateTime createAt) : base(id, createAt)
        {
            Vehicle = vehicle;
            Note = note;
            InputPrice = inputPrice;
            Buyer = buyer;
            InputDate = inputDate;
            LicensePlate = licensePlate;
            new ValidationContract<VehicleSales>(this);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        public void AddBuyer(Buyer buyer)
        {
            Buyer = buyer;
        }

        public Guid VehicleId { get; private set; }
        public Guid BuyerId { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public string Note { get; private set; }
        public decimal InputPrice { get; private set; }
        public Buyer Buyer { get; private set; }
        public DateTime InputDate { get; private set; }
        public Guid LicensePlate { get; private set; }
    }
}
