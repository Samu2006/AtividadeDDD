namespace PC2.Shared.Commands
{
    public interface ICommandHandler<T> where T : ICommandInput
    {
        ICommandResult Handle(T command);
    }
}
