using FluentValidator;
using PC2.Domain.Customers.Commands.Inputs;
using PC2.Domain.Customers.Commands.Results;
using PC2.Domain.Customers.Entities;
using PC2.Domain.Customers.Repositories;
using PC2.Domain.Shared.Commands.Handlers;
using PC2.Domain.Shared.Commands.Inputs;
using PC2.Domain.Shared.Entities;
using PC2.Domain.Shared.Repositories;
using PC2.Domain.Shared.ValueObjects;
using PC2.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC2.Domain.Customers.Commands.Handlers
{
    public class BuyerHandler : Notifiable, ICommandHandler<BuyerInput>
    {
        private IAddressRepository _addressRepository;
        private IBuyerRepository _buyerRepository;

        public BuyerHandler(IAddressRepository addressRepository,
            IBuyerRepository buyerRepository)
        {
            _addressRepository = addressRepository;
            _buyerRepository = buyerRepository;
        }

        public ICommandResult Handle(BuyerInput command)
        {
            //Criar a entidade
            Name name = new Name(command.FirstName, command.LastName);

            AddressInput addressInput = new AddressInput(command.Number, command.Street, command.PublicPlace,
                                                         command.City, command.State, command.ZipCode);
            AddressHandler addressHandler = new AddressHandler(_addressRepository);
            addressHandler.Handle(addressInput);
            Address address = addressHandler.GetByZipCode(addressInput.ZipCode);

            Buyer buyer = new Buyer(name, address, command.Birthday, command.Gender, command.Phone);

            //Validação
            //AddNotifications(addressHandler.Notifications);
            AddNotifications(buyer.Notifications);
            AddNotifications(name.Notifications);
            //Notificação
            if (!IsValid())
            {
                var message = Notifications.ToString();
                foreach (var item in Notifications.ToList())
                {
                    message = item.Message.ToString() + "\n";
                }
                return new CustomerResult(message); ;
            }
            _buyerRepository.Save(buyer);
            return new CustomerResult("Cadastro Realizado com Sucesso!!");
        }

        public Buyer GetBuyer(Guid id)
        {
            return _buyerRepository.GetById(id);
        }

        public IEnumerable<Buyer> HandlerListBuyer()
        {
            return _buyerRepository.List();

        }
        public IEnumerable<Buyer> ListBuyer()
        {
            var list = _buyerRepository.List();

            return list;
        }
    }
}
