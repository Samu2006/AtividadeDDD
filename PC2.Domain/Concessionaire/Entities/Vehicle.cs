using PC2.Shared.Entities;
using System;

namespace PC2.Domain.Concessionaire.Entities
{
    public class Vehicle : Entity
    {
        public Vehicle()
        {

        }

        public Vehicle(Model model, string version, int year, int yearFabrication,
            string color, string renavan)
        {
            Model = model;
            Version = version;
            Year = year;
            YearFabrication = yearFabrication;
            Color = color;
            Renavan = renavan;
        }
        public Vehicle(Guid id, Model model, string version, int year, int yearFabrication,
       string color, string renavan, DateTime createAt) : base(id, createAt)
        {
            Model = model;
            Version = version;
            Year = year;
            YearFabrication = yearFabrication;
            Color = color;
            Renavan = renavan;
        }
        public void Update(Model model, string version, string brand, int year, int yearFabrication,
            string color, string renavan)
        {
            Model = model;
            Version = version;
            Brand = brand;
            Year = year;
            YearFabrication = yearFabrication;
            Color = color;
            Renavan = renavan;
        }

        public void AddModel(Model model)
        {
            Model = model;
        }

        public Guid ModelId { get; private set; }
        public Model Model { get; private set; }
        public string Version { get; private set; }
        public string Brand { get; private set; }
        public int Year { get; private set; }
        public int YearFabrication { get; private set; }
        public string Color { get; private set; }
        public string Renavan { get; private set; }

        public override string ToString()
        {
            return Model.NameModel + " " + Version;
        }
    }
}
