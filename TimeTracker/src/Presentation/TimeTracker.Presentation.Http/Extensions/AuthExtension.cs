using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using TimeTracker.Application.Jwt;

namespace TimeTracker.Presentation.Http.Extensions;

public static class AuthExtension
{
    // public static IApplicationBuilder UseAuth(this IApplicationBuilder app)
    // {
    //     app.UseMiddleware<AuthMiddleware>();
    //     return app;
    // }
    public static IServiceCollection AddAuth(
        this IServiceCollection services,
        IConfigurationSection jwtOptionsSection)
    {
        ArgumentNullException.ThrowIfNull(jwtOptionsSection);

        services.Configure<JwtOptions>(jwtOptionsSection);
        services.AddSingleton(jwtOptionsSection.Get<JwtOptions>()!);

        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(jwtOptions =>
            {
                var configKey = jwtOptionsSection["Key"];
                if (string.IsNullOrWhiteSpace(configKey))
                {
                    throw new InvalidOperationException("JWT key is missing");
                }

                var key = Encoding.UTF8.GetBytes(configKey);

                jwtOptions.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = jwtOptionsSection["Issuer"],
                    ValidAudience = jwtOptionsSection["Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true
                };
            });

        return services.AddSwaggerAuth();
    }

    public static IServiceCollection AddSwaggerAuth(
        this IServiceCollection services)
    {
        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
            option.AddSecurityDefinition(
                "Bearer",
                new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

            option.AddSecurityRequirement(
                new OpenApiSecurityRequirement
                {
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

        return services;
    }
}