namespace CrimsonDev.Gameteki.Data
{
    using JsonApiFramework;
    using JsonApiFramework.Client;
    using JsonApiFramework.JsonApi;

    public class PatreonDocumentContext : DocumentContext
    {
        public PatreonDocumentContext(Document document)
            : base(document)
        {
        }

        protected override void OnConfiguring(IDocumentContextOptionsBuilder optionsBuilder)
        {
            var conventions = JsonApiConfigurationFactory.CreateConventions();
            var serviceModel = JsonApiConfigurationFactory.CreateServiceModel();

            optionsBuilder.UseConventions(conventions);
            optionsBuilder.UseServiceModel(serviceModel);
        }
    }
}