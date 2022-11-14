using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using WEB_API_FRONTEND.Data;
using WEB_API_FRONTEND.Interface;
using WEB_API_FRONTEND.Services;
using Blazored.Toast;
using Blazored.Modal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient<InterfaceStudent, StudentService>(client => client.BaseAddress = new Uri("https://localhost:7009"));
builder.Services.AddHttpClient<InterfaceFaculty, FacultyService>(client => client.BaseAddress = new Uri("https://localhost:7009"));
builder.Services.AddHttpClient<InterfaceCourse, CourseService>(client => client.BaseAddress = new Uri("https://localhost:7009"));

builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredModal();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
