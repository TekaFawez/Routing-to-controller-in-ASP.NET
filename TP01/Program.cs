using Microsoft.AspNetCore.Routing.Constraints;
using TP01.Constraints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "max",

    pattern: "{controller=Test}/{action=Max}/{value1=0}/{value2=0}",
    constraints: new
    {
        value1 = @"-?\d+",
        value2 = @"-?\d+",

        methode = new HttpMethodRouteConstraint("GET"),
        x = new PortConstraints()
    }
);
    
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Test}/{action=Welcome}/{id?}"); 
//id parmetre de l'action l'action c'est route



app.Run();
