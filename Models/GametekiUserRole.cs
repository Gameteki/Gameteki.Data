namespace CrimsonDev.Gameteki.Data.Models
{
    public class GametekiUserRole
    {
        public virtual GametekiUser User { get; set; }
        public int UserId { get; set; }
        public virtual GametekiRole Role { get; set; }
        public int RoleId { get; set; }
    }
}