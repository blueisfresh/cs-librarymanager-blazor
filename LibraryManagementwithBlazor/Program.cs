using LibraryManagementwithBlazor.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryManagementwithBlazor.Data;
using LibraryManagementwithBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<LibraryManagementwithBlazorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryManagementwithBlazorContext") ?? throw new InvalidOperationException("Connection string 'LibraryManagementwithBlazorContext' not found.")));

builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<BorrowService>();

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
