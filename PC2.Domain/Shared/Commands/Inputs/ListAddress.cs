using PC2.Shared.Commands;

namespace PC2.Domain.Shared.Commands.Inputs
{
    public class ListAddress : ICommandInput
    {
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
