var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//Relier les vues au contoilleurs
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//configurer les routes : le formet des url
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Welcome}/{action=WelcomeDefault}/{id?}"
);

app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Welcome}/{action=WelcomeName}/{nom?}/{prenom?}"
);

app.MapControllerRoute(
 name: "default",
 //pattern :structure de l'url : peut contenir le controlleur
 //La méthode d'action et les paramètres
 pattern: "{nom}/{prenom}",
 //defaults: indique le controlleur et la méthode d'action par défaut  
 defaults: new { controller = "Welcome", action = "WelcomeName"}
);

app.Run();
