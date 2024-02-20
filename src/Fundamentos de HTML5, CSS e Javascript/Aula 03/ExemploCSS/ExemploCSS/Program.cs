var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();//index.html
app.UseStaticFiles();//HTML, JS e CSS

app.Run();
