using Engine.BusinessLogic.ClockLogic;
using Engine.BusinessLogic.DrawLogic;
using Engine.BusinessLogic.ResetLogic;
using Engine.Core;
using Engine.Core.Connection;
using Engine.Core.Threading;
using Engine.DeviceUtils.LEDMatrixWS2812B;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IDeviceConnector, StaticConnector>();
            services.AddSingleton<IDrawSinglePixel, SinglePixelDrawer>();
            services.AddSingleton<ITestConnector, SimpleTestConnector>();
            services.AddSingleton<IStateHandler, SimpleStateHandler>();
            services.AddSingleton<IDeviceRunner, DeviceRunner>();
            services.AddSingleton<IResetLogic, ResetLogic>();
            services.AddSingleton<IPixelPointer, ArrayPixelPointer>();
            services.AddSingleton<IThreadHandler, MainThreadHandler>();
            services.AddSingleton<IClockLogic, SimpleClockLogic>();
            services.AddSingleton<ICancelHandler, TaskCancelHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}