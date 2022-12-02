using BmesRestApi.Database;
using BmesRestApi.Repositories;
using BmesRestApi.Repositories.Implementations;
using BmesRestApi.Repository;
using BmesRestApi.Repository.Implementations;
using BmesRestApi.Services;
using BmesRestApi.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddMemoryCache();

builder.Services.AddSession();

builder.Services.AddDistributedMemoryCache();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BmesDbContext>(options => options.UseSqlite(
    builder.Configuration["Data:BmesApi:ConnectionString"]
    ));
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
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSession();

app.UseAuthorization();

app.MapControllers();

app.Run();
