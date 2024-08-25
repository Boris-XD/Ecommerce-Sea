using Microsoft.EntityFrameworkCore;
using Sea.Ecommerce.Repository;
using Sea.Ecommerce.Repository.Stores;
using Sea.Ecommerce.Service.Stores;
using Sea.Ecommerce.Service.Stores.Mapper;

namespace Sea.Ecommerce.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Mapper configuration
            builder.Services.AddAutoMapper(typeof(StoreMappingProfile));

            // Services
            builder.Services.AddScoped<IStoreService, StoreService>();

            // Data Services
            builder.Services.AddTransient<IStoreRepository, StoreRepository>();

            builder.Services.AddDbContext<StoreDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            // Add services to the container.

            builder.Services.AddControllers();

            // Logging
            builder.Services.AddApplicationInsightsTelemetry(options: options =>
            {
                options.ConnectionString = builder.Configuration.GetValue<string>("ApplicationInsights:ConnectionString");
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
