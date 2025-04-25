//configuration is like useContext, read from anywhere
// connection string,api keys, constatnt email address, domain names, api calls, client IDs etc...
// configuration source could be in appsetting.json, Enviroment Variables, File Configuration, in-memory configuration, Secret Manager
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();



app.UseStaticFiles();
app.UseRouting();


app.MapControllers();

//app.Map("/config", async (context) =>
//{
//    // case in sensitive
//    await context.Response.WriteAsync(app.Configuration["mykey"] + "\n");

//    // return object type, mention <string> to get rid of error 
//    await context.Response.WriteAsync(app.Configuration.GetValue<string>("mykey") + "\n");

//    // int value
//    await context.Response.WriteAsync(app.Configuration.GetValue<int>("y") + "\n");

//    // default value
//    await context.Response.WriteAsync(app.Configuration.GetValue<int>("x", 10) + "\n");

//});

app.Run();
