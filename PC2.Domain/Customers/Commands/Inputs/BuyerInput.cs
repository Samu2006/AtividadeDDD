using PC2.Domain.Customers.Enums;
using PC2.Shared.Commands;
using System;

namespace PC2.Domain.Customers.Commands.Inputs
{
    public class BuyerInput : ICommandInput
    {
        public string FirstName { get;  set; }
        public string LastName { get; set; }

        public string Number { get; set; }
        public string Street { get; set; }
        public string PublicPlace { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public DateTime Birthday { get;  set; }
        public EGender Gender { get;  set; }
        public string Nationality { get;  set; }
        public string Phone { get;  set; }
    }
}
