var builder = WebApplication.CreateBuilder(args);
{
    //inyeccion de dependencia Container
    builder.Services.AddControllers();
}


var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

