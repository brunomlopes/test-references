using CoreWebSss.ServiceInterface;
using Funq;
using ServiceStack;
using WebApplication1;

[assembly: HostingStartup(typeof(CoreWebSss.AppHost))]

namespace CoreWebSss;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("CoreWebSss", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        SetupContainer.Setup(container);
        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(new HostConfig {
            UseSameSiteCookies = true,
        });
    }
}
