using Microsoft.EntityFrameworkCore;
using TaskApi.Context;
using TaskApi.ITaskRepository;
using TaskApi.TaskRepository;

namespace TaskApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<TaskDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnction"));

            });
            builder.Services.AddTransient<ITask, TaskRepo>();
            builder.Services.AddTransient<ISubTask, SubTaskRepo>();

            // Add Required Dependencies here
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}