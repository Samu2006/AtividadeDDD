using FluentValidator;
using PC2.Domain.Concessionaire.Commands.Inputs.Vehicles;
using PC2.Domain.Concessionaire.Commands.Results;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Concessionaire.Repositories;
using PC2.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC2.Domain.Concessionaire.Commands.Handlers
{
    public class VehicleHandler : Notifiable, ICommandHandler<VehiclesInput>
    {
        private IVehicleRepository _vehicleRepository;
        private IModelRepository _modelRepository;

        public VehicleHandler(IVehicleRepository vehicleRepository, IModelRepository modelRepository)
        {
            _vehicleRepository = vehicleRepository;
            _modelRepository = modelRepository;
        }

        public ICommandResult Handle(VehiclesInput command)
        {
            //Criar entidade
            Model model = _modelRepository.GetById(Guid.Parse(command.Model));

            Vehicle vehicle = new Vehicle(model, command.Version, command.Year,
                command.YearFabrication, command.Color, command.Renavan);
            //Validação
            AddNotifications(vehicle.Notifications);
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
            //Persistir No banco
            _vehicleRepository.Save(vehicle);

            return new ConcessionaireResult("Cadastrado com Sucesso!!");
        }

        public Vehicle GetVehicle(Guid id)
        {
            return _vehicleRepository.GetById(id);
        }
        public IEnumerable<Vehicle> HandlerListVehicle()
        {
            return _vehicleRepository.List();
        }
        public IEnumerable<Vehicle> UniqueModel()
        {
            var list = _vehicleRepository.List2();
            foreach (var item in list)
            {
                item.AddModel(_modelRepository.GetById(item.ModelId));
            }
            return list;
        }
        public IEnumerable<Vehicle> HandlerListByModel()
        {

            var list = _vehicleRepository.List();
            foreach (var item in list)
            {

                _vehicleRepository.ListByModel(item.ModelId);
            }
            return list;

        }
        public IEnumerable<Vehicle> Lista(Guid id)
        {

            var list = _vehicleRepository.ListByM(id);
           
            return list;

        }
        public IEnumerable<Vehicle> ListVehicle()
        {

            var list = _vehicleRepository.List();
            
            return list;

        }
    }
}
