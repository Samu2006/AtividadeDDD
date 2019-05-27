using FluentValidator;
using PC2.Domain.Shared.Commands.Inputs;
using PC2.Domain.Shared.Commands.Results;
using PC2.Domain.Shared.Entities;
using PC2.Domain.Shared.Repositories;
using PC2.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC2.Domain.Shared.Commands.Handlers
{
    public class AddressHandler : Notifiable, ICommandHandler<AddressInput>
    {
        private IAddressRepository _addressRepository;

        public AddressHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public ICommandResult Handle(AddressInput command)
        {
            //Criar a entidade
            Address address = new Address(command.Number, command.Street, command.PublicPlace,
                command.City, command.State, command.ZipCode);
            //Validação
            AddNotifications(address.Notifications);

            //Notificação
            if (!IsValid())
            {
                var message = string.Empty;
                foreach (var item in Notifications.ToList())
                {
                    message = item.Message.ToString() + "\n";
                }
                return new SharedResult(message); ;
            }

            //Persistir no banco
            _addressRepository.Save(address);

            return new SharedResult("Cadastrado com Sucesso!!");

        }
        public Address GetAddress(Guid id)
        {
            return _addressRepository.GetById(id);
        }

        public Address GetByZipCode(string cep)
        {
            return _addressRepository.GetByCEP(cep);
        }
        public IEnumerable<Address> ListAddress()
        {
            return _addressRepository.List();
        }
    }
}
