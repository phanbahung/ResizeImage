using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResizeImage.Startup))]
namespace ResizeImage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
