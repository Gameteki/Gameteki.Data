namespace CrimsonDev.Gameteki.Data.Models
{
    public class GametekiPermissions
    {
        public bool CanManageUsers { get; set; }
        public bool CanEditNews { get; set; }
        public bool CanManagePermissions { get; set; }
        public bool CanManageGames { get; set; }
        public bool CanManageNodes { get; set; }
        public bool CanModerateChat { get; set; }
        public bool IsSupporter { get; set; }
        public bool IsContributor { get; set; }
        public bool IsAdmin { get; set; }
    }
}
