using FluentValidator;
using PC2.Shared.Entities;
using System;

namespace PC2.Domain.Concessionaire.Entities
{
    public class Model : Entity
    {
        public Model()
        {

        }

        public Model(string nameModel)
        {
            NameModel = nameModel;
            new ValidationContract<Model>(this)
                .IsRequired(x => x.NameModel, "Campo vazio, preencha com o nome do Modelo");
        }
        public Model(Guid id, string nameModel, DateTime createAt) : base(id, createAt)
        {
            NameModel = nameModel;
            new ValidationContract<Model>(this)
                .IsRequired(x => x.NameModel, "Campo vazio, preencha com o nome do Modelo");
        }

        public string NameModel { get; private set; }

        public override string ToString()
        {
            return NameModel;
        }
    }
}
