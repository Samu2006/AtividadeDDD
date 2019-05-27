using FluentValidator;
using PC2.Domain.Customers.Enums;
using PC2.Domain.Shared.Entities;
using PC2.Domain.Shared.ValueObjects;
using PC2.Shared.Entities;
using System;

namespace PC2.Domain.Customers.Entities
{
    public class Buyer : Entity
    {
        public Buyer()
        {

        }

        public Buyer(Name name, Address address, DateTime birthday, EGender gender, string phone)
        {
            Name = name;
            Address = address;
            Birthday = birthday;
            Gender = gender;
            Phone = phone;
            AddNotifications(name.Notifications);
            //AddNotifications(address.Notifications);
            new ValidationContract<Buyer>(this)
                .IsRequired(x=>x.Phone,"Campo telefone vazio, necessario preencher");
        }

        public Buyer(Name name, Address address, Document document,
            Email email, DateTime birthday,
            EGender gender, string nationality, string phone)
        {
            Name = name;
            Address = address;
            Document = document;
            Email = email;
            Birthday = birthday;
            Gender = gender;
            Nationality = nationality;
            Phone = phone;
        }
        public Buyer(Guid id, Name name, Address address, Document document,
            Email email, DateTime birthday,
            EGender gender, string nationality, string phone, DateTime createAt) : base(id, createAt)
        {
            Name = name;
            Address = address;
            Document = document;
            Email = email;
            Birthday = birthday;
            Gender = gender;
            Nationality = nationality;
            Phone = phone;
        }

        public void Update(Name name, Address address, Document document,
            Email email, DateTime birthday, EGender gender,
            string nationality, string phone)
        {
            Name = name;
            Address = address;
            Document = document;
            Email = email;
            Birthday = birthday;
            Gender = gender;
            Nationality = nationality;
            Phone = phone;
        }
        public void AddAddress(Address address)
        {
            Address = address;
        }
        public void AddName(Name name)
        {
            Name = name;
        }
        public Guid AddressId { get; private set; }

        public Name Name { get; private set; }
        public Address Address { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public DateTime Birthday { get; private set; }
        public EGender Gender { get; private set; }
        public string Nationality { get; private set; }
        public string Phone { get; private set; }

        public override string ToString()
        {
            return Name.FirstName + " " + Name.LastName;
        }
    }
}
