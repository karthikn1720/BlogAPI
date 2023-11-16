
using Blogs.API.Models.Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var connString = builder.Configuration.GetConnectionString("DbConnectionString");
builder.Services.AddNpgsql<BlogAppContext>(connString);
builder.Services.AddCors(options =>
                    {
                        options.AddDefaultPolicy(builder =>
                        {
                            builder.WithOrigins("*")
                                   .AllowAnyMethod()
                                   .AllowAnyHeader();
                        });
                    });




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();


app.UseAuthorization();

// app.UseRouting();
app.UseCors();
app.MapControllers();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.Run();
