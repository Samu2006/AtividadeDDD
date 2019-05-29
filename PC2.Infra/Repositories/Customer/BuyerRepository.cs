using Dapper;
using PC2.Domain.Customers.Entities;
using PC2.Domain.Customers.Repositories;
using PC2.Domain.Shared.Entities;
using PC2.Domain.Shared.Repositories;
using PC2.Domain.Shared.ValueObjects;
using PC2.Infra.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC2.Infra.Repositories.Customer
{
    public class BuyerRepository : IBuyerRepository
    {
        private IDB _DB;
        private IAddressRepository _addressRepository;

        public BuyerRepository(IDB DB)
        {
            _DB = DB;
        }

        public BuyerRepository(IDB DB, IAddressRepository addressRepository)
        {
            _DB = DB;
            _addressRepository = addressRepository;
        }

        public Buyer GetById(Guid id)
        {
            using (var db = _DB.GetConnection())
            {
                var sql = "SELECT *, B.FirstName, B.LastName,B.CPF " +
                            "  FROM [Buyer]	B     " +
                            "INNER JOIN [Address] A  ON A.[Id] = B.[AddressId]" +
                            "WHERE B.[Id] =@Id";
                var listBuyer = db.Query<Buyer, Address, Name,Document,Buyer>(sql, map: (buyer, address, name,document) =>
                {
                    address = new Address(address.Id, address.Number, address.Street,
                    address.PublicPlace, address.City, address.State, address.ZipCode, address.CreateAt);
                    name = new Name(name.FirstName, name.LastName);
                    document = new Document(document.Number);
                    buyer = new Buyer(buyer.Id, name, address, document,
                        buyer.Email, buyer.Birthday, buyer.Gender, buyer.Nationality, buyer.Phone, buyer.CreateAt);
                    return buyer;
                }, param: new { Id = id }, splitOn: "Id,Id,FirstName,CPF").FirstOrDefault();
                return listBuyer;
            }
        }

        public Buyer GetByName(string id)
        {
            using (var db = _DB.GetConnection())
            {
                return db.QueryFirstOrDefault<Buyer>("SELECT * FROM [Buyer] WHERE " +
                    "[FirstName]=@FirstName ",
                    new
                    {
                        FirstName = id
                    });
            }
        }

        public IEnumerable<Buyer> List()
        {
            using (var db = _DB.GetConnection())
            {

                var sql = "SELECT *, B.FirstName, B.LastName,B.CPF AS Number " +
                          "  FROM [Buyer]	B     " +
                          "INNER JOIN [Address] A  ON A.[Id] = B.[AddressId]";
                var listBuyer = db.Query<Buyer, Address, Name,Document, Buyer>(sql, map: (buyer, address, name,document) =>
                {
                    address = new Address(address.Id, address.Number, address.Street,
                    address.PublicPlace, address.City, address.State, address.ZipCode, address.CreateAt);
                    name = new Name(name.FirstName, name.LastName);
                    document = new Document(document.Number);
                    buyer = new Buyer(buyer.Id, name, address, document,
                        buyer.Email, buyer.Birthday, buyer.Gender, buyer.Nationality, buyer.Phone, buyer.CreateAt);
                    return buyer;
                }, splitOn: "Id,FirstName,Number");
                return listBuyer;

            }
        }
        //public IEnumerable<Buyer> List()
        //{
        //    using (var db = _DB.GetConnection())
        //    {

        //        var sql = "SELECT B.[Id] AS Id " +
        //                  "      ,B.[Birthday]	As Birthday	" +
        //                  "      ,B.[Phone]	As Phone		" +
        //                  "      ,A.[City] AS City" +
        //                  "      ,A.[State] AS State" +
        //                  "      ,A.[ZipCode] AS ZipCode   " +
        //                  "      ,B.[FirstName]	As FirstName	" +
        //                  "      ,B.[LastName]	As LastName	" +
        //                  "  FROM [Buyer]	B     " +
        //                  "INNER JOIN [Address] A  ON A.[Id] = B.[AddressId]";
        //        var listBuyer = db.Query<Buyer, Address, Name, Buyer>(sql, map: (buyer, address, name) =>
        //        {

        //            address = new Address(address.Id, address.Number, address.Street,
        //            address.PublicPlace, address.City, address.State, address.ZipCode, address.CreateAt);
        //            name = new Name(name.FirstName, name.LastName);
        //            buyer = new Buyer(buyer.Id,name, address,buyer.Document,
        //                buyer.Email,buyer.Birthday, buyer.Gender, buyer.Nationality,buyer.Phone,buyer.CreateAt);
        //            return buyer;
        //        }, splitOn: "Id,City,FirstName");
        //        return listBuyer;

        //    }
        //}

        public void Save(Buyer buyer)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("INSERT INTO [Buyer]" +
                    "([Id]" +
                    ",[AddressId]" +
                    ",[FirstName]" +
                    ",[LastName]" +
                    ",[Birthday]" +
                    ",[Gender]" +
                    ",[Phone]" +
                    ",[CreateAt])" +
                    "VALUES" +
                    "(@Id" +
                    ",@AddressId" +
                    ",@FirstName" +
                    ",@LastName" +
                    ",@Birthday" +
                    ",@Gender" +
                    ",@Phone" +
                    ",@CreateAt)",
                    new
                    {
                        Id = buyer.Id,
                        AddressId = buyer.Address.Id,
                        FirstName = buyer.Name.FirstName,
                        LastName = buyer.Name.LastName,
                        Birthday = buyer.Birthday,
                        Gender = buyer.Gender,
                        Phone = buyer.Phone,
                        CreateAt = buyer.CreateAt
                    });
            }
        }

        public void Update(Buyer buyer)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("UPDATE [Buyer] SET" +
                    "[AddressId]=AddressId" +
                    ",[FirstName]=@FirstName" +
                    ",[LastName]=@LastName" +
                    ",[Birthday]=@Birthday" +
                    ",[Gender]=@Gender" +
                    ",[Phone]=@Phone" +
                    ",[CPF]=@CPF" +
                    ",[Email]=@Email" +
                    ",[Nationality]=@Nationality" +
                    "WHERE [Id]=@Id",
                      new
                      {
                          Id = buyer.Id,
                          AddressId = buyer.Address.Id,
                          FirstName = buyer.Name.FirstName,
                          LastName = buyer.Name.LastName,
                          Birthday = buyer.Birthday,
                          Gender = buyer.Gender,
                          Phone = buyer.Phone,
                          CPF = buyer.Document.Number,
                          Email = buyer.Email.EmailAddress,
                          Nationality = buyer.Nationality
                      });

            }
        }
    }
}
