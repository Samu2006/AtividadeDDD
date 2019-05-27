using PC2.Shared.Commands;

namespace PC2.Domain.Concessionaire.Commands.Results
{
    public class ConcessionaireResult : ICommandResult
    {
        public ConcessionaireResult()
        {

        }
        public ConcessionaireResult(object message)
        {
            Message = message;
        }

        public object Message { get; set; }
    }
}
