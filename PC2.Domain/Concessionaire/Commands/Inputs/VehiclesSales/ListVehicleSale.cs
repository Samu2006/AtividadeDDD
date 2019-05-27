using PC2.Shared.Commands;
using System;

namespace PC2.Domain.Concessionaire.Commands.Inputs.VehiclesSales
{
    public class ListVehicleSale : ICommandInput
    {
        public string Version { get; set; }
        public string Color { get; set; }
        public string Note { get; set; }
        public decimal InputPrice { get; set; }
        public string Name { get; set; }
        public DateTime InputDate { get; set; }
        public Guid LicensePlate { get; set; }
    }
}
