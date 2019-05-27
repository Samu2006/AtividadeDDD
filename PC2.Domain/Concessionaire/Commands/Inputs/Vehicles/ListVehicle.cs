using PC2.Shared.Commands;

namespace PC2.Domain.Concessionaire.Commands.Inputs.Vehicles
{
    public class ListVehicle : ICommandInput
    {

        public string NameModel { get; set; }
        public string Version { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int YearFabrication { get; set; }
        public string Color { get; set; }
        public string Renavan { get; set; }
    }
}
