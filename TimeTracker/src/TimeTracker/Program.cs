// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
#pragma warning disable CA1506
using Itmo.Dev.Platform.Common.Extensions;
using Itmo.Dev.Platform.Logging.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using TimeTracker.Application.Extensions;
using TimeTracker.Infrastructure.Persistence.Extensions;
using TimeTracker.Presentation.Http.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

builder.Services.AddOptions<JsonSerializerSettings>();
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<JsonSerializerSettings>>().Value);

builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();
builder.Services.AddApplication();
builder.Services.AddInfrastructurePersistence(builder.Configuration);

// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
//         options => builder.Configuration.Bind("JwtSettings", options))
//     .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
//         options => builder.Configuration.Bind("CookieSettings", options));

builder.Services
    .AddControllers()
    .AddNewtonsoftJson()
    .AddPresentationHttp();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.AddPlatformSerilog(builder.Configuration);
builder.Services.AddUtcDateTimeProvider();

WebApplication app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
// app.UseAuthorization();
app.MapControllers();

await app.RunAsync();