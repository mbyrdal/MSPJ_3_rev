var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving of static files in wwwroot.
// Override default "index.html" and serve "Customer.html" instead.
app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "Customer.html" }
});

app.UseStaticFiles();

app.Run();