namespace CrimsonDev.Gameteki.Data.Models
{
    public class GametekiRole
    {
        public GametekiRole()
        {
        }

        public GametekiRole(string roleName)
        {
            Name = roleName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
