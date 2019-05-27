using PC2.Shared.Commands;

namespace PC2.Domain.Customers.Commands.Results
{
    public class CustomerResult:ICommandResult
    {
        public CustomerResult(object message)
        {
            Message = message;
        }

        public object Message { get; set; }
    }
}
