using PC2.Domain.Concessionaire.Entities;
using PC2.Shared.Commands;
using System;

namespace PC2.Domain.Concessionaire.Commands.Inputs.VehiclesSales
{
    public class VehicleSalesInput : ICommandInput
    {
        public VehicleSalesInput()
        {
            LicensePlate = Guid.Parse(Guid.NewGuid().ToString().ToUpper());
            //Year = _sale._vehicle.Year;
            //YearFabrication = _sale._vehicle.YearFabrication;
        }
        public string Vehicle { get; set; }
        public int Year { get; set; }
        public int YearFabrication { get; set; }
        public string Color { get; set; }
        public string Note { get; set; }
        public decimal InputPrice { get; set; }
        public string Buyer { get; set; }
        public decimal InputValue { get; set; }
        public DateTime InputDate { get; set; }
        public Guid LicensePlate { get; set; }
    }
}
