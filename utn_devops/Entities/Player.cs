namespace utn_devops.Entities
{
    public class Player
    {
        private long _birthday;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthday { 
            get
            {
                DateTime birthday = new DateTime(_birthday);
                return birthday.ToString("dd/MM/yyyy");
            }
        }

        public Player(string name, string lastName, long birthday)
        {
            Name = name;
            LastName = lastName;
            _birthday = birthday;
        }
    }
}