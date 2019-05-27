using FluentValidator;
using PC2.Shared.Entities;
using System;

namespace PC2.Domain.Shared.Entities
{
    public class Address : Entity
    {
        public Address()
        {

        }

        public Address(string number, string street, string publicPlace,
            string city, string state, string zipCode)
        {
            Number = number;
            Street = street;
            PublicPlace = publicPlace;
            City = city;
            State = state;
            ZipCode = zipCode;
            new ValidationContract<Address>(this)
                .IsRequired(x => x.City,"Campo cidade vazio, necessario preenchimento")
                .IsRequired(x => x.PublicPlace, "Campo bairro vazio, necessario preenchimento")
                .IsRequired(x => x.State, "Campo estado vazio, necessario preenchimento")
                .IsRequired(x => x.Street, "Campo rua vazio, necessario preenchimento");

        }
        public Address(Guid id,string number, string street, string publicPlace,
           string city, string state, string zipCode,DateTime createAt):base(id,createAt)
        {
            Number = number;
            Street = street;
            PublicPlace = publicPlace;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public void Update(string number, string street, string publicPlace, string city,
            string state, string zipCode, string complement)
        {
            Number = number;
            Street = street;
            PublicPlace = publicPlace;
            City = city;
            State = state;
            ZipCode = zipCode;
            Complement = complement;
        }

        public string Number { get; private set; }
        public string Street { get; private set; }
        public string PublicPlace { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string Complement { get; private set; }


    }
}
