var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add(String.Concat("http://0.0.0.0:", port));

app.MapGet("/", () => "Hello Cloud Run!");

app.Run();