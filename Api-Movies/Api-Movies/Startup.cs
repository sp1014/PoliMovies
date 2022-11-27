using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Api_Movies.Models;
using Api_Movies.Core.UserDataManager;
using Api_Movies.Core.LoginManager;
using Api_Movies.Core.UserManager;
using Api_Movies.Core.FileManager;
using Api_Movies.Core.MovieManager;
using Api_Movies.Core.RentalManager;
using Api_Movies.Core.SaleManager;
using Api_Movies.Core.ColectionsManager;
using Api_Movies.Core.QualificationManager;
using Api_Movies.Core.SerieManager;
using Api_Movies.Core.IdiomManager;

namespace Api_Movies
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var key = Encoding.ASCII.GetBytes(Configuration.GetValue<string>("SecretKey"));

            services.AddAuthentication(x => {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddCors();
            services.AddControllers();
            #region Inyeccion de dependencias
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IUserDataManager, UserDataManager>();
            services.AddScoped<ILoginManager, LoginManager>();
            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<IMovieManager, MovieManager>();
            services.AddScoped<IRentalManager, RentalManager>();
            services.AddScoped<ISaleManager, SaleManager>();
            services.AddScoped<IColectionsManager, ColectionsManager>();
            services.AddScoped<IQualificationManager, QualificationManager>();
            services.AddScoped<ISerieManager, SerieManager>();
            services.AddScoped<IIdiomManager, IdiomManager>();
            /* 
             services.AddScoped<ICourseManager, CourseManager>();
             services.AddScoped<ICalificacionManager, CalificacionManager>();
             services.AddScoped<IAllocationLoadManager, AllocationLoadManager>();
             services.AddScoped<IFollowUpCourseManager, FollowUpCourseManager>();
             services.AddScoped<IScheduleManager, ScheduleManager>();
             services.AddScoped<IGradeManager, GradeManager>();*/
            #endregion
            services.AddDbContext<UsersContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("PoliMovies")));
            //This can either be due to a cycle or if the object depth is larger than the maximum allowed depth of 32.
            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NetPOLIx", Version = "v1" });
            });

            services.AddSwaggerGen(config =>
            {
                ////Name the security scheme
                config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });

                config.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                  {
                   new OpenApiSecurityScheme
                      {
                      Reference = new OpenApiReference
                        {
                        Type = ReferenceType.SecurityScheme,

                        //The name of the previously defined security scheme.
                         Id = "Bearer"
                      }

                    },
                 new List<string>()
                  }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(options => options.WithOrigins("*").AllowAnyHeader().AllowAnyMethod());
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "NetPOLIx V1");
            });

        }
    }
}



