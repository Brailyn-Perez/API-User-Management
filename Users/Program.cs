
using Microsoft.EntityFrameworkCore;
using Users.Context;
using Users.Daos;
using Users.Interfaces;

namespace Users
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<UsersContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("UsersDB"));
            });

            builder.Services.AddScoped<IDaoUsers, DaoUsers>();



            var app = builder.Build();

            /*
                        using (var scope = app.Services.CreateScope())
                        {
                            var dataContext = scope.ServiceProvider.GetRequiredService<UsersContext>();
                            dataContext.Database.Migrate();
                        }
            */

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
