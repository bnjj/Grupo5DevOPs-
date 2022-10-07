namespace utn_devops.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Player(string name, string lastName, DateTime birthday)
        {
            Name = name;
            LastName = lastName;
            Birthday = birthday;
        }
    }
}