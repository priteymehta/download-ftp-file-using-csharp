using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FTPDemo.Startup))]
namespace FTPDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
