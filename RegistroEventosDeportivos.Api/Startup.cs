
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer("YourConnectionStringHere"));

    services.AddScoped<ProductoService>();
    services.AddControllers();
}
