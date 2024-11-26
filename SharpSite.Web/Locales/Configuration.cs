namespace SharpSite.Web.Locales;
public static class Configuration
{

	public readonly static string[] SupportedCultures = { 
		"bg-BG",
		"en-US", 
		"fr-FR",
		"nl-NL",
		"sw-KE",
	};

	/// <summary>
	/// add the custom localization features for the application framework
	/// </summary>
	/// <param name="builder"></param>
	public static void ConfigureRequestLocalization(this WebApplicationBuilder builder)
	{

		builder.Services.Configure<RequestLocalizationOptions>(options =>
		{
			
			options.SetDefaultCulture("en-US")
									.AddSupportedCultures(SupportedCultures)
									.AddSupportedUICultures(SupportedCultures);
		});

		builder.Services.AddLocalization(options =>
		{
			options.ResourcesPath = "Locales";
		});

	}
}