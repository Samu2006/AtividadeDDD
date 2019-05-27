using FluentValidator;

namespace PC2.Domain.Shared.ValueObjects
{
    public class Name : Notifiable
    {
        public Name()
        {

        }
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            new ValidationContract<Name>(this)
                .HasMinLenght(x => x.FirstName, 3, "Campo invalido, quantidade minima de 3 caracteres")
                .HasMaxLenght(x => x.LastName, 50, "Campo invalido, quantidade maxima de 50 caracteres");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
