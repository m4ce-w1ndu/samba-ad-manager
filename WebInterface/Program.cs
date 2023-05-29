using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using WebInterface.Data;

namespace WebInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddLocalization(options => options.ResourcesPath = "SharedResources");

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseRequestLocalization(new RequestLocalizationOptions()
                                             .SetDefaultCulture("en-US")
                                             .AddSupportedCultures("en-US", "it-IT")
                                             .AddSupportedUICultures("en-US", "it-IT"));

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}