using PC2.Shared.Commands;
using System;

namespace PC2.Domain.Shared.Commands.Inputs
{
    public class AddressInput : ICommandInput
    {
        public AddressInput(string number, string street, string publicPlace, string city, string state, string zipCode)
        {
            Number = number;
            Street = street;
            PublicPlace = publicPlace;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string PublicPlace { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
