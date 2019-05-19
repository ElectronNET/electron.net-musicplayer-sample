using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using ElectronNET.API;

namespace MyElectronMusicPlayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateBuildWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateBuildWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseElectron(args);
    }
}
