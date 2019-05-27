using FluentValidator;

namespace PC2.Domain.Shared.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string emailAddress)
        {
            EmailAddress = emailAddress;

            new ValidationContract<Email>(this);
                
        }

        public string EmailAddress { get; private set; }
    }
}
