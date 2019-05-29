using Dapper;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Concessionaire.Repositories;
using PC2.Domain.Customers.Entities;
using PC2.Domain.Customers.Repositories;
using PC2.Domain.Shared.Entities;
using PC2.Domain.Shared.ValueObjects;
using PC2.Infra.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC2.Infra.Repositories.Concessionaire
{
    public class VehicleSalesRepository : IVehicleSalesRepository
    {
        private IDB _DB;
        private IBuyerRepository _buyerRepository;
        private IVehicleRepository _vehicleRepository;

        public VehicleSalesRepository(IDB DB, IBuyerRepository buyerRepository,
            IVehicleRepository vehicleRepository)
        {
            _DB = DB;
            _buyerRepository = buyerRepository;
            _vehicleRepository = vehicleRepository;
        }

        public VehicleSales GetById(Guid id)
        {
            using (var db = _DB.GetConnection())
            {
                return db.QueryFirstOrDefault<VehicleSales>("SELECT * FROM [Vehicle] WHERE [Id]=@id",
                  new
                  {
                      Id = id
                  });
            }
        }
        public IEnumerable<VehicleSales> List()
        {
            using (var db = _DB.GetConnection())
            {
                var sql = "SELECT *" +
                          "  FROM[VehicleSales] VS" +
                          "INNER JOIN[Vehicle] V ON VS.[VehicleId] = V.[Id]" +
                          "INNER JOIN[Buyer] B ON VS.[BuyerId] = B.[Id]    ";
                var listVehicleSale = db.Query<VehicleSales, Vehicle, Buyer, VehicleSales>(sql, map: (sale, vehicle, buyer) =>
                {
                    vehicle = _vehicleRepository.GetById(sale.VehicleId);
                    sale.AddVehicle(vehicle);
                    buyer = _buyerRepository.GetById(sale.BuyerId);
                    sale.AddBuyer(buyer);
                    return sale;
                },
                       splitOn: "Id");
                return listVehicleSale;
            }
        }

        public void Save(VehicleSales vehicleSales)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("INSERT INTO [VehicleSales]" +
                    "([Id]" +
                    ",[VehicleId]" +
                    ",[BuyerId]" +
                    ",[Note]" +
                    ",[InputPrice]" +
                    ",[InputDate]" +
                    ",[LicensePlate]" +
                    ",[CreateAt])" +
                    "VALUES" +
                    "(@Id" +
                    ",@VehicleId" +
                    ",@BuyerId" +
                    ",@Note" +
                    ",@InputPrice" +
                    ",@InputDate" +
                    ",@LicensePlate" +
                    ",@CreateAt)",
                    new
                    {
                        Id = vehicleSales.Id,
                        VehicleId = vehicleSales.Vehicle.Id,
                        BuyerId = vehicleSales.Buyer.Id,
                        Note = vehicleSales.Note,
                        InputPrice = vehicleSales.InputPrice,
                        InputDate = vehicleSales.InputDate,
                        LicensePlate = vehicleSales.LicensePlate,
                        CreateAt = vehicleSales.CreateAt
                    });
            }
        }

        public void Update(VehicleSales vehicleSales)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("UPDATE [VehicleSales] SET" +
                    "[VehicleId]=@VehicleId" +
                    ",[BuyerId]=@BuyerId" +
                    ",[Note]=@Note" +
                    ",[InputPrice]=@InputPrice" +
                    ",[InputDate]=@InputDate" +
                    ",[LiscensePlate]=@LiscensePlate" +
                    "WHERE [Id]=@Id",
                    new
                    {
                        Id = vehicleSales.Id,
                        VehicleId = vehicleSales.Vehicle.Id,
                        BuyerId = vehicleSales.Buyer.Id,
                        Note = vehicleSales.Note,
                        InputPrice = vehicleSales.InputPrice,
                        InputDate = vehicleSales.InputDate,
                        LicensePlate = vehicleSales.LicensePlate,
                    });
            }
        }
    }
}
