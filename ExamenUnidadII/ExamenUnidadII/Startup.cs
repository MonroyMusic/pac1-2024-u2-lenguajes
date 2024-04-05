using ExamenUnidadII.Database;
using Microsoft.EntityFrameworkCore;

namespace ExamenUnidadII
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
                
            Configuration = configuration;

        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            services.AddDbContext<IMCDatabaseContext>(options =>

                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddCors(options =>
            {

                options.AddDefaultPolicy(builder =>
                {

                    builder.WithOrigins(Configuration["FrontendURL"])
                    .AllowAnyHeader()
                    .AllowAnyMethod();

                });

            });
            services.AddAutoMapper(typeof(Startup));

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
