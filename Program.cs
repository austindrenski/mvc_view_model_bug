using Microsoft.AspNetCore.Hosting;

namespace mvc_view_model_bug
{
    public static class Program
    {
        public static void Main() => CreateWebHostBuilder().Build().Run();

        static IWebHostBuilder CreateWebHostBuilder()
            => new WebHostBuilder()
               .UseStartup<Startup>()
               .UseKestrel();
    }
}