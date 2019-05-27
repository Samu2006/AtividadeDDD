using FluentValidator;
using PC2.Domain.Concessionaire.Commands.Inputs.VehiclesSales;
using PC2.Domain.Concessionaire.Commands.Results;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Concessionaire.Repositories;
using PC2.Domain.Customers.Entities;
using PC2.Domain.Customers.Repositories;
using PC2.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC2.Domain.Concessionaire.Commands.Handlers
{
    public class VehicleSalesHandler : Notifiable, ICommandHandler<VehicleSalesInput>
    {
        private IVehicleSalesRepository _salesRepository;
        private IVehicleRepository _vehicleRepository;
        private IBuyerRepository _buyerRepository;

        public VehicleSalesHandler(IVehicleSalesRepository salesRepository,
            IVehicleRepository vehicleRepository, IBuyerRepository buyerRepository)
        {
            _salesRepository = salesRepository;
            _vehicleRepository = vehicleRepository;
            _buyerRepository = buyerRepository;
        }

        public ICommandResult Handle(VehicleSalesInput command)
        {
            //Criar a entidade
            Vehicle vehicle = _vehicleRepository.GetById(Guid.Parse(command.Vehicle));
            Buyer buyer = _buyerRepository.GetById(Guid.Parse(command.Buyer));
            VehicleSales vehicleSales = new VehicleSales(vehicle, command.Note, command.InputPrice,
                                                        buyer, command.InputDate,command.LicensePlate);

            //Validação
            AddNotifications(vehicleSales.Notifications);
            //Notificação
            if (!IsValid())
            {
                var message = string.Empty;
                foreach (var item in Notifications.ToList())
                {
                    message = item.Message.ToString() + "\n";
                }
                return new ConcessionaireResult(message); ;
            }
            _salesRepository.Save(vehicleSales);
            return new ConcessionaireResult("Vendido com Sucesso!!");
        }

        //public IEnumerable<VehicleSales> ListVehicleSales()
        //{
        //    var list = _salesRepository.List();
        //    foreach (var item in list)
        //    {
        //        item.AddVehicle(_vehicleRepository.GetById(item.VehicleId));
        //    }
        //    foreach (var item in list)
        //    {
        //        item.AddBuyer(_buyerRepository.GetById(item.BuyerId));
        //    }
        //    return list;
        //}

        public IEnumerable<VehicleSales> ListSales()
        {
            var list =_salesRepository.List();
            return list;
        }

        public IEnumerable<VehicleSales> HandlerListVehicleSales()
        {
            return _salesRepository.List();
        }

        public VehicleSales GetVehicleSales(Guid id)
        {
            return _salesRepository.GetById(id);
        }
    }
}
