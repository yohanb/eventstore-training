using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                var page = context.Request.Path.ToUriComponent();
                if (page.EndsWith(".html")) RouteToPage(page, context);
                else RouteToCommandHandler(page, context);
            });
        }

        private static void RouteToCommandHandler(string commandHandler, HttpContext context) {
            switch (commandHandler) {
                case "book-room":
                    //.HandleCommand(new BookRoomCommand());
                    break;
                default:
                    context.Response.SendFileAsync("401.html");
                    break;
            }
        }

        private static void RouteToPage(string page, HttpContext context) {
            if (context.Request.Path == "/")
            {
                context.Response.WriteAsync(File.ReadAllText("pages/index.html"));        
            }


            var pageContents = File.ReadAllText("pages/" + page);
                
        }
    }
}