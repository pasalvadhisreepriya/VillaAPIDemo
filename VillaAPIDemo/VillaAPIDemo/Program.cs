//using Serilog;

using VillaApi;
using VillaApi.Data;
using VillaApi.Logging;
using Microsoft.EntityFrameworkCore;
using VillaApi.Repository.IRepository;
using VillaApi.Repository;
using VillaAPIDemo.Repository.IRepository;
using VillaAPIDemo.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//SQL dependency injection
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});


//register repository in program.cs
builder.Services.AddScoped<IVillaRepository, VillaRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IVillaNumberRepository, VillaNumberRepository>();

//Inject Automapper dependency
builder.Services.AddAutoMapper(typeof(MappingConfig));

//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().
//WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();

// builder.Host.UseSerilog();


builder.Services.AddControllers(option =>
{
    //option.ReturnHttpNotAcceptable=true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");
builder.Services.AddAuthentication(x =>
{
	x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

})
  .AddJwtBearer(x =>
  {
	  x.RequireHttpsMetadata = false;
	  x.SaveToken = true;
	  x.TokenValidationParameters = new TokenValidationParameters()
	  {
		  ValidateIssuerSigningKey = true,
		  IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
		  ValidateIssuer = false,
		  ValidateAudience = false
	  };
  });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
	options =>
	{
		options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
		{
			Description =
		   "JWT Authorization header using the Bearer scheme. \r\n\r\n " +
			"Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\n" +
			"Example: \"Bearer 12345abcdef\"",
			Name = "Authorization",
			In = ParameterLocation.Header,
			Scheme = "Bearer"
		});
		options.AddSecurityRequirement(new OpenApiSecurityRequirement()
	{
		{
			new OpenApiSecurityScheme
			{
				Reference = new OpenApiReference
							{
								Type = ReferenceType.SecurityScheme,
								Id = "Bearer"
							},
				Scheme = "oauth2",
				Name = "Bearer",
				In = ParameterLocation.Header
			},
			new List<string>()
		}
	});
	});
//builder.Services.AddSingleton<ILogging, Logging>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
