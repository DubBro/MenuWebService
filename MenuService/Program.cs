using SoapCore;
using System.ServiceModel.Channels;
using MenuWebService.Services;
using MenuWebService.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddSingleton<IDishService, DishService>();
builder.Services.AddSingleton<IMenuService, MenuService>();
builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();

app.UseSoapEndpoint<IMenuService>("/MenuService", new SoapEncoderOptions
{
    MessageVersion = MessageVersion.Soap12WSAddressingAugust2004
});

app.Run();
