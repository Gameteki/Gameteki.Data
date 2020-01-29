namespace CrimsonDev.Gameteki.Data
{
    using Humanizer;
    using JsonApiFramework.Conventions;

    public class UnderscoreNamingConvention : INamingConvention
    {
        public string Apply(string oldName)
        {
            return string.IsNullOrWhiteSpace(oldName) ? oldName : oldName.Underscore();
        }
    }
}