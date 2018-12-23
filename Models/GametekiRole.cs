namespace CrimsonDev.Gameteki.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class GametekiRole : IdentityRole<string>
    {
        public GametekiRole()
        {
        }

        public GametekiRole(string roleName)
            : base(roleName)
        {
        }
    }
}
