using FunctionApp10;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults(builder =>
    {
        builder.UseMiddleware<exceptionhandlingmiddleware>();
    })
    .ConfigureServices(service =>
    {
    })
    .Build();

host.Run();
