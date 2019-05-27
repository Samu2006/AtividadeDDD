using PC2.Domain.Shared.Entities;
using PC2.Domain.Shared.Repositories;
using PC2.Infra.Infra;
using System;
using System.Collections.Generic;
using Dapper;

namespace PC2.Infra.Repositories.Shared
{
    public class AddressRepository : IAddressRepository
    {
        private IDB _DB;

        public AddressRepository(IDB DB)
        {
            _DB = DB;
        }

        public Address GetByCEP(string cep)
        {
            using (var db = _DB.GetConnection())
            {
                return db.QueryFirstOrDefault<Address>("SELECT * FROM [Address] WHERE [ZipCode]=@ZipCode",
                    new
                    {
                        ZipCode = cep
                    });
            }
        }

        public Address GetById(Guid id)
        {
            using (var db = _DB.GetConnection())
            {
                return db.QueryFirstOrDefault<Address>("SELECT * FROM [Address] WHERE [Id]=@Id",
                    new
                    {
                        Id = id
                    });
            }
        }

        public IEnumerable<Address> List()
        {
            using (var db = _DB.GetConnection())
            {
                return db.Query<Address>("SELECT * FROM [Address]");
            }
        }

        public void Save(Address address)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("INSERT INTO [Address]" +
                    "([Id]" +
                    ",[Number]" +
                    ",[Street]" +
                    ",[PublicPlace]" +
                    ",[City]" +
                    ",[State]" +
                    ",[ZipCode]" +
                    ",[CreateAt])" +
                    "VALUES" +
                    "(@Id" +
                    ",@Number" +
                    ",@Street" +
                    ",@PublicPlace" +
                    ",@City" +
                    ",@State" +
                    ",@ZipCode" +
                    ",@CreateAt)",
                    new
                    {
                        Id = address.Id,
                        Number = address.Number,
                        Street = address.Street,
                        PublicPlace = address.PublicPlace,
                        City = address.City,
                        State = address.State,
                        ZipCode = address.ZipCode,
                        CreateAt = address.CreateAt
                    });
            }
        }

        public void Update(Address address)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("UPDATE [Address] SET" +
                    "[Number]=@Number" +
                    ",[Street]=@Street" +
                    ",[PublicPlace]=@PublicPlace" +
                    ",[City]=@City" +
                    ",[State]=@State" +
                    ",[ZipCode]=@Zipcode" +
                    ",[Complement]=@Complement" +
                    "WHERE [Id]=@Id",
                   new
                   {
                       Id = address.Id,
                       Number = address.Number,
                       Street = address.Street,
                       PublicPlace = address.PublicPlace,
                       City = address.City,
                       State = address.State,
                       ZipCode = address.ZipCode,
                       Complement = address.Complement
                   });
            }
        }
    }
}
