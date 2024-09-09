using IMS.Plugins.InMemory;
using IMS.UseCases.Inventory;
using IMS.UseCases.Inventory.Interfaces;
using IMS.UseCases.PluginInterfaces;
using IMS.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();

builder.Services.AddTransient<IViewInventoryByName, ViewInventoryByName>();
builder.Services.AddTransient<IAddInventory, AddInventory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();
