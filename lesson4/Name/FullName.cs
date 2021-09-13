namespace lesson4.Name
{
   public class FullName
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Patronymic { get; init; }

        public FullName(string firstname, string lastname, string patronymic)
        {
            FirstName = firstname ?? throw new NamePartNullException("firstname is null");
            LastName = lastname ?? throw new NamePartNullException("lastname is null");
            Patronymic = patronymic ?? throw new NamePartNullException("patronimic is null");
        }

        public string GetName() => string.Format($"{FirstName} {Patronymic} {LastName}");
    }
}
