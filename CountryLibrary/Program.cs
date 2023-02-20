using CountryLibrary.Services;
using CountryLibrary.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ITeamServices, TeamServiceLocalData>();
builder.Services.AddSingleton<ICountryService,CountryService>();

var app = builder.Build();

app.MapControllers();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
