using BlazorAppSandboxComponent;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace bazor_app_sandbox
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // �u���E�U��ł̓���Ȃ̂ŃV���O���g���ŗǂ��B
            // �������ACORS�̊֌W��API�͌Ăяo���Ȃ��B
            services.AddSingleton<MackerelApi.mackerel_apiClient>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
