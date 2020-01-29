namespace CrimsonDev.Gameteki.Data
{
    using CrimsonDev.Gameteki.Data.Models;
    using CrimsonDev.Gameteki.Data.Models.Patreon;
    using JsonApiFramework.Conventions;
    using JsonApiFramework.ServiceModel;
    using JsonApiFramework.ServiceModel.Configuration;

    public static class JsonApiConfigurationFactory
    {
        public static IConventions CreateConventions()
        {
            var conventionsBuilder = new ConventionsBuilder();

            conventionsBuilder.ApiAttributeNamingConventions()
                .AddStandardMemberNamingConvention();
            conventionsBuilder.ApiTypeNamingConventions()
                .AddPluralNamingConvention()
                .AddStandardMemberNamingConvention();
            conventionsBuilder.ResourceTypeConventions()
                .AddPropertyDiscoveryConvention();

            var conventions = conventionsBuilder.Create();

            return conventions;
        }

        public static IServiceModel CreateServiceModel()
        {
            var serviceModelBuilder = new ServiceModelBuilder();

            serviceModelBuilder.Configurations.Add(new PatreonUserConfiguration());
            serviceModelBuilder.Configurations.Add(new PatreonPledgeConfiguration());
            serviceModelBuilder.Configurations.Add(new PatreonRewardConfiguration());
            serviceModelBuilder.Configurations.Add(new PatreonCampaignConfiguration());

            // Configure the ApiEntryPoint resource as the "home" document.
            serviceModelBuilder.HomeResource<PatreonUser>();

            var conventions = CreateConventions();
            var serviceModel = serviceModelBuilder.Create(conventions);

            return serviceModel;
        }
    }
}