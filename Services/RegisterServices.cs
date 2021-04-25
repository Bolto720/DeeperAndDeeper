using Microsoft.Extensions.DependencyInjection;
using DeeperAndDeeper.Service.SectorMapServices;
using DeeperAndDeeper.Service.SectorServices;
using DeeperAndDeeper.Service.SolarBodyServices;

namespace DeeperAndDeeper.Service.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection collection)
        {
            collection.AddScoped<ISectorMapService, SectorMapService>();
            collection.AddScoped<ISectorService, SectorService>();
            collection.AddScoped<ISolarBodyService, SolarBodyService>();
        }
    }
}