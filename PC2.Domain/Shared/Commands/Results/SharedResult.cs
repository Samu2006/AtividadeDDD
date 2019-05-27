using PC2.Shared.Commands;

namespace PC2.Domain.Shared.Commands.Results
{
    public class SharedResult:ICommandResult
    {
        public SharedResult(object message)
        {
            Message = message;
        }

        public object Message { get; set; }
    }
}
