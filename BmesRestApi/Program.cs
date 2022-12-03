using BmesRestApi.Database;
using BmesRestApi.Infrastructure;
using BmesRestApi.Models.Shared;
using BmesRestApi.Repositories;
using BmesRestApi.Repositories.Implementations;
using BmesRestApi.Repository;
using BmesRestApi.Repository.Implementations;
using BmesRestApi.Services;
using BmesRestApi.Services.Implementations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddMemoryCache();

builder.Services.AddSession();

builder.Services.AddDistributedMemoryCache();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer",
        new OpenApiSecurityScheme
        {
            Description = "JWT Authorization header using the Bearer scheme.",
            Type = SecuritySchemeType.Http,
            Scheme = "bearer"
        });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                    {
                        new OpenApiSecurityScheme{
                            Reference = new OpenApiReference{
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        },
                        new List<string>()
                    }
                });
});
//builder.Services.AddDbContext<BmesDbContext>(options => options.UseSqlServer(
//    builder.Configuration["Data:BmesApi:ConnectionString"]
//    ));
builder.Services.AddDbContext<BmesDbContext>(options => options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")
)
);

builder.Services.AddIdentity<User,IdentityRole>()
    .AddEntityFrameworkStores<BmesDbContext>();

//Extension method that configured JWT
builder.Services.AddJwtAuth(builder.Configuration);

builder.Services.AddTransient<IBrandRepository, BrandRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();

builder.Services.AddTransient<ICartRepository, CartRepository>();
builder.Services.AddTransient<ICartItemRepository, CartItemRepository>();

builder.Services.AddTransient<IAddressRepository,AddressRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<IPersonRepository,PersonRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IOrderItemRepository, OrderItemRepository>();

builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ICatalogueService, CatalogueService>();
builder.Services.AddTransient<ICartService,CartService>();
builder.Services.AddTransient<IOrderService,OrderService>();
builder.Services.AddTransient<ICheckoutService,CheckoutService>();

builder.Services.AddTransient<IAuthRepository, AuthRepository>();
builder.Services.AddTransient<IAuthService, AuthService>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSession();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetService<BmesDbContext>();
    var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
    var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
    // Create the Db if it doesn't exist and applies any pending migration.
    //dbContext.Database.Migrate();

    IdentityDbSeeder.Seed(dbContext, roleManager, userManager);
}

app.Run();
