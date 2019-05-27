using Dapper;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Concessionaire.Repositories;
using PC2.Infra.Infra;
using System;
using System.Collections.Generic;

namespace PC2.Infra.Repositories.Concessionaire
{
    public class ModelRepository : IModelRepository
    {
        private IDB _DB;

        public ModelRepository(IDB DB)
        {
            _DB = DB;
        }

        public Model GetById(Guid id)
        {
            using (var db = _DB.GetConnection())
            {
                return db.QueryFirstOrDefault<Model>("SELECT * FROM [Model] WHERE [Id]=@Id",
                    new
                    {
                        Id = id
                    });
            }
        }

        public IEnumerable<Model> List()
        {
            using (var db = _DB.GetConnection())
            {
                return db.Query<Model>("SELECT * FROM [Model]");
            }
        }

        public IEnumerable<Model> ListDistinct()
        {
            using (var db = _DB.GetConnection())
            {
                return db.Query<Model>("SELECT DISTINCT [NameModel] FROM [Model]");
            }
        }

        public void Save(Model model)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("INSERT INTO [Model]" +
                    "([Id]" +
                    ",[NameModel]" +
                    ",[CreateAt])" +
                    "VALUES" +
                    "(@Id" +
                    ",@NameModel" +
                    ",@CreateAt)",
                    new
                    {
                        Id = model.Id,
                        NameModel = model.NameModel,
                        CreateAt = model.CreateAt
                    });
            }
        }

        public void Update(Model model)
        {
            using (var db = _DB.GetConnection())
            {
                db.Execute("UPDATE [Model] SET" +
                    "[Name]=@Name" +
                    "WHERE [Id]=@Id",
                    new
                    {
                        Id = model.Id,
                        Name = model.NameModel,
                    });
            }
        }
    }
}
