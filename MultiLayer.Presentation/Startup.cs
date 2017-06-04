using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MultiLayer.Presentation.Startup))]

namespace MultiLayer.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
