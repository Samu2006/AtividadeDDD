using PC2.Shared.Commands;
using System;

namespace PC2.Domain.Concessionaire.Commands.Inputs.Models
{
    public class ListModel : ICommandInput
    {
        public Guid Id { get; set; }
        public string NameModel { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
