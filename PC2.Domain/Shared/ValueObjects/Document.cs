using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC2.Domain.Shared.ValueObjects
{
    public class Document : Notifiable
    {
        public Document(string number)
        {
            Number = number;
            new ValidationContract<Document>(this)
                .IsRequired(x => x.Number, "Campo Cpf vazio, preencha o campo");
        }

        public string Number { get; private set; }
    }
}
