using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;
using MYPROJECT2.Services;

namespace MYPROJECT2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<FDFVanløseContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
           
            builder.Services.AddTransient<IChild, ChildService>();
            builder.Services.AddTransient<IGroups, GroupService>();
            builder.Services.AddTransient<ILeaders, LeaderService>();

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

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}