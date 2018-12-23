namespace CrimsonDev.Gameteki.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class GametekiUserRole : IdentityUserRole<string>
    {
        public virtual GametekiUser User { get; set; }
        public virtual GametekiRole Role { get; set; }
    }
}