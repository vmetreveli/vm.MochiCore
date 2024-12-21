using Asp.Versioning.ApiExplorer;

namespace  vm.MochiCore.Api.Swagger;

public class ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) : IConfigureOptions<SwaggerGenOptions>
{
    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in provider.ApiVersionDescriptions)
            options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
    }

    private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
    {
        var info = new OpenApiInfo
        {
            Title = "MochiCore API",
            Version = description.ApiVersion.ToString(),
            Description = "Description for the MochiCore",
            Contact = new OpenApiContact { Name = "vm.MochiCore" }
        };

        if (description.IsDeprecated) info.Description += " This API version has been deprecated.";

        return info;
    }
}