using Dapper;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Concessionaire.Repositories;
using PC2.Infra.Infra;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC2.Infra.Repositories.Concessionaire
{
    public class VehicleRepository : IVehicleRepository
    {
        private IDB _DB;

        public VehicleRepository(IDB DB)
        {
            _DB = DB;
        }
        public Vehicle GetById(Guid id)
        {
            using (var db = _DB.GetConnection())
            {
                var sql = @"SELECT * " +
                         " FROM [Vehicle] V	" +
                         "INNER JOIN [Model] M	ON V.[ModelId] = M.[Id] ";
                var listVehicle = db.Query<Vehicle, Model, Vehicle>(sql,
                    map: (vehicle, models) => { vehicle.AddModel(models); return vehicle; }, splitOn: "Id,Id",
                    param: new { Id = id }).FirstOrDefault();
                return listVehicle;

            }
        }
        //public Vehicle GetById(Guid id)
        //{
        //    using (var db = _DB.GetConnection())
        //    {
        //        var sql = "SELECT [Id]              " +
        //                "      ,[ModelId]		  " +
        //                "      ,[Version]		  " +
        //                "      ,[Year]			  " +
        //                "      ,[YearFabrication] " +
        //                "      ,[Color]			  " +
        //                "      ,[Renavan]		  " +
        //                "      ,[Brand]			  " +
        //                "  FROM [Vehicle]		 " +
        //                "WHERE [Id]=@Id ";
        //        return db.QueryFirstOrDefault<Vehicle>(sql,
        //            new
        //            {
        //                Id = id
        //            });
        //    }
        //}
        public IEnumerable<Vehicle> List2()
        {
            using (var db = _DB.GetConnection())
            {
                var sql = "SELECT DISTINCT [ModelId]  " +
                          "  FROM [Vehicle]		  ";
                var listVehicle = db.Query<Vehicle>(sql);
                return listVehicle;
            }
        }

        public IEnumerable<Vehicle> ListByM(Guid id)
        {
            using (var db = _DB.GetConnection())
            {
                var sql = "SELECT  [Color],[Version]  " +
                          "  FROM [Vehicle]	 WHERE	[ModelId]=@ModelId  ";
                var listVehicle = db.Query<Vehicle>(sql, new { ModelId = id });
                return listVehicle;
            }
        }

        //public IEnumerable<Vehicle> List()
        //{
        //    using (var db = _DB.GetConnection())
        //    {
        //        var sql = "SELECT [Id]              " +
        //                 "      ,[ModelId]		  " +
        //                 "      ,[Version]		  " +
        //                 "      ,[Year]			  " +
        //                 "      ,[YearFabrication] " +
        //                 "      ,[Color]			  " +
        //                 "      ,[Renavan]		  " +
        //                 "      ,[Brand]			  " +
        //                 "  FROM [Vehicle]		  ";
        //        var listVehicle = db.Query<Vehicle>(sql);
        //        return listVehicle;
        //    }
        //}

        //public IEnumerable<Vehicle> List()
        //{
        //    using (var db = _DB.GetConnection())
        //    {
        //        var sql = "SELECT V.[Id]   As Id          " +
        //                 "      ,[Version]		  " +
        //                 "      ,[Year]			  " +
        //                 "      ,[YearFabrication] " +
        //                 "      ,[Color]			  " +
        //                 "      ,[Renavan]		  " +
        //                 "      ,[Brand] " +
        //                 "      ,M.[NameModel] AS NameModel " +
        //                 "  FROM [Vehicle] V	" +
        //                 "INNER JOIN [Model] M	ON V.[ModelId] = M.[Id]  ";
        //        var listVehicle = db.Query<Vehicle, Model, Vehicle>(sql, map: (vehicle, models) =>
        //        {
        //            models = new Model(models.NameModel);
        //            vehicle = new Vehicle(models, vehicle.Version, vehicle.Year,
        //                vehicle.YearFabrication, vehicle.Color, vehicle.Renavan);
        //            return vehicle;
        //        },
        //           splitOn: "Id ,NameModel");
        //        return listVehicle;
        //    }
        //}
        public IEnumerable<Vehicle> List()
        {
            using (var db = _DB.GetConnection())
            {
                var sql = @"SELECT * " +
                         " FROM [Vehicle] V	" +
                         "INNER JOIN [Model] M	ON V.[ModelId] = M.[Id] ";
                var listVehicle = db.Query<Vehicle, Model, Vehicle>(sql,
                    map: (vehicle, models) => { vehicle.AddModel(models); return vehicle; });
                return listVehicle;
            }
        }

        public IEnumerable<Vehicle> ListByModel(Guid model)
        {
            using (var db = _DB.GetConnection())
            {
                var sql = "SELECT [Id]              " +
                          "      ,[Version]		  " +
                          "      ,[Year]			  " +
                          "      ,[YearFabrication] " +
                          "      ,[Color]			  " +
                          "      ,[Renavan]		  " +
                          "      ,[Brand]			  " +
                          "  FROM [Vehicle]		  " +
                          "WHERE [ModelId]=@ModelId";

                var listVehicle = db.Query<Vehicle>(sql,
                       new
                       {
                           ModelId = model
                       });
                return listVehicle;
            }
        }

        public void Save(Vehicle vehicle)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("INSERT INTO [Vehicle]" +
                    "([Id]" +
                    ",[ModelId]" +
                    ",[Version]" +
                    ",[Year]" +
                    ",[YearFabrication]" +
                    ",[Color]" +
                    ",[Renavan]" +
                    ",[CreateAt])" +
                    "VALUES" +
                    "(@Id" +
                    ",@ModelId" +
                    ",@Version" +
                    ",@Year" +
                    ",@YearFabrication" +
                    ",@Color" +
                    ",@Renavan" +
                    ",@CreateAt)",
                    new
                    {
                        Id = vehicle.Id,
                        ModelId = vehicle.Model.Id,
                        Version = vehicle.Version,
                        Year = vehicle.Year,
                        YearFabrication = vehicle.YearFabrication,
                        Color = vehicle.Color,
                        Renavan = vehicle.Renavan,
                        CreateAt = vehicle.CreateAt
                    });
            }
        }

        public void Update(Vehicle vehicle)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("UPDATE [Vehicle] SET" +
                    "[ModelId]=@ModelId" +
                    ",[Brand]=@Band" +
                    ",[Version]=@Version" +
                    ",[Year]=@Year" +
                    ",[YearFabrication]=@YearFabrication" +
                    ",[Color]=@Color" +
                    ",[Renavan]=@Renavan",
                  new
                  {
                      Id = vehicle.Id,
                      ModelId = vehicle.Model.Id,
                      Brand = vehicle.Brand,
                      Version = vehicle.Version,
                      Year = vehicle.Year,
                      YearFabrication = vehicle.YearFabrication,
                      Color = vehicle.Color,
                      Renavan = vehicle.Renavan,

                  });
            }
        }

        public Vehicle GetByName(string id)
        {
            using (var db = _DB.GetConnection())
            {
                var sql = "SELECT [Id]              " +
                        "      ,[ModelId]		  " +
                        "      ,[Year]			  " +
                        "      ,[YearFabrication] " +
                        "      ,[Color]			  " +
                        "      ,[Renavan]		  " +
                        "      ,[Brand]			  " +
                        "  FROM [Vehicle]		 " +
                        "WHERE [Version]=@Version ";
                return db.QueryFirstOrDefault<Vehicle>(sql,
                    new
                    {
                        Version = id
                    });
            }
        }
    }
}
