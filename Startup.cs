using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace mvc_view_model_bug
{
    public class Startup : IStartup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
            => services.AddLogging(x => x.AddConsole())
                       .AddMvc()
                       .Services
                       .BuildServiceProvider();

        public void Configure(IApplicationBuilder app)
            => app.UseMvc();
    }
}