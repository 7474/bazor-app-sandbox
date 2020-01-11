using BlazorAppSandboxComponent;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace bazor_app_sandbox
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // ブラウザ上での動作なのでシングルトンで良い。
            // ただし、CORSの関係上APIは呼び出せない。
            services.AddSingleton<MackerelApi.mackerel_apiClient>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
