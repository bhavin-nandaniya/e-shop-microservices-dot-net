var builder = WebApplication.CreateBuilder(args);

// Add Services to the container.

var app = builder.Build();

// Configure the HTTP requests pipeline.

app.Run();
