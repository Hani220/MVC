using Microsoft.Extensions.FileSystemGlobbing.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            var app = builder.Build();
            app.UseRouting();

            #region 
            //app.UseEndpoints(endpoints =>
            //    {
            //        // Home Page Route
            //        endpoints.MapGet("/Home", async context =>
            //        {
            //            await context.Response.WriteAsync("You Are At HomePage");
            //        });

            //        // Products Page Route with optional ID
            //        endpoints.MapGet("/Products/{ID?}", async context =>
            //        {
            //            var idData = context.Request.RouteValues["ID"];
            //            if (idData != null)
            //            {
            //                int data = Convert.ToInt32(idData);
            //                await context.Response.WriteAsync($"You Are At Products Page with ID => {data}");
            //            }
            //            else
            //            {
            //                await context.Response.WriteAsync("You Are At Products Page");
            //            }
            //        });

            //        endpoints.MapGet("/Books/{ID}/{Author:alpha:minlength(6):maxlength(50)}", async context =>
            //        {
            //            var id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            //            string name = context.Request.RouteValues["Author"].ToString();
            //            await context.Response.WriteAsync($"You Are At Products Page with ID => {id},at Author Name {name} ");

            //        });
            //        });
            #endregion

            app.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Home}/{action=Index}",
                 defaults: new { controller = "Home", action = "Index" }
             );



            //app.Run(async (HttpContent) => { await HttpContent.Response.WriteAsync("Your Page Not Found"); });
            app.Run();
        }
    }
    
}
