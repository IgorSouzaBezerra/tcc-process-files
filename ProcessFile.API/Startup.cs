using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ProcessFile.API.Infra.Context;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Infra.Repositories;
using ProcessFile.API.Job;
using ProcessFile.API.Providers.implementations;
using ProcessFile.API.Providers.Interface;
using ProcessFile.API.Services.Interfaces;
using ProcessFile.API.Services.Services;
using ProcessFile.API.Token;
using System;
using System.Text;

namespace ProcessFile.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddDefaultPolicy(builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));

            services.AddControllers()
                .AddNewtonsoftJson(
                options =>
                options.SerializerSettings
                .ReferenceLoopHandling = Newtonsoft.Json
                .ReferenceLoopHandling.Ignore
            );

            
            var secretKey = Configuration["Jwt:Key"];
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });


            services.AddDbContext<ApplicationContext>(options => 
                options.UseSqlServer(Configuration["ConnectionStrings:ConnectionDefault"])
            );
            services.AddScoped<IColumnControlService, ColumnControlService>();
            services.AddScoped<IColumnControlRepository, ColumnControlRepository>();
            services.AddScoped<IProcessService, ProcessService>();
            services.AddScoped<IProcessRepository, ProcessRepository>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<ISulamericaService, SulamericaService>();
            services.AddScoped<ISulamericaRepository, SulamericaRepository>();
            services.AddScoped<IUnimedService, UnimedService>();
            services.AddScoped<IUnimedRepository, UnimedRepository>();
            services.AddScoped<IJobEventService, JobEventService>();
            services.AddScoped<IJobEventRepository, JobEventRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IHash, Hash>();
            services.AddScoped<ITokenGenerator, TokenGenerator>();

            services.AddHangfire(options =>
            {
                options.UseMemoryStorage();
            });
            services.AddHangfireServer();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Manager API",
                    Version = "v1",
                    Description = "API.",
                    Contact = new OpenApiContact
                    {
                        Name = "Igor",
                        Email = "igor@igor.com",
                        Url = new Uri("https://github.com/IgorSouzaBezerra")
                    },
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Por favor utilize Bearer <TOKEN>",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProcessFile.API v1"));
            }

            app.UseRouting();

            app.UseCors();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseHangfireDashboard();
            RecurringJob.AddOrUpdate(() => JobEMail.Execute(), Cron.Minutely);
        }
    }
}
