var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// To serve index.html as default page.
app.UseDefaultFiles();

// Enable serving static files like HTML, CSS & JS.
app.UseStaticFiles();

// Build a web application using C# for the backend.
// Uses HTML/CSS/JavaScript in the frontend (through wwwroot folder).
app.Run();
