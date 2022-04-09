using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyGallery.UI.Application.Mapper.Profiles;

namespace MyGallery.UI.Application.Mapper;

public static class ConfigurationExtensions
{
    public static IServiceCollection AddUIMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => cfg.AddUIProfiles());
        return services;
    }

    public static IMapperConfigurationExpression AddUIProfiles(this IMapperConfigurationExpression configuration)
    {
        configuration.AddProfile<CarProfile>();
        configuration.AddProfile<CarCategoryProfile>();
        configuration.AddProfile<BrandProfile>();
        return configuration;
    }
}