using FluentValidator;
using PC2.Domain.Concessionaire.Commands.Inputs.Models;
using PC2.Domain.Concessionaire.Commands.Results;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Concessionaire.Repositories;
using PC2.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC2.Domain.Concessionaire.Commands.Handlers
{
    public class ModelHandler : Notifiable, ICommandHandler<ModelsInput>
    {
        private IModelRepository _modelRepository;

        public ModelHandler(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        public ICommandResult Handle(ModelsInput command)
        {
            Model model = new Model(command.Name);

            //Validação
            AddNotifications(model.Notifications);
            // Notificações
            if (!IsValid())
            {
                var message = string.Empty;
                foreach (var item in Notifications.ToList())
                {
                    message = item.Message.ToString() + "\n";
                }
                return new ConcessionaireResult(message); ;
            }
            //Persistir no Banco
            _modelRepository.Save(model);

            return new ConcessionaireResult("Cadastrado com Sucesso!!");
        }

        public Model GetModel(Guid id)
        {
            return _modelRepository.GetById(id);
        }

        public IEnumerable<Model> List()
        {
            return _modelRepository.List();
        }
    }
}
