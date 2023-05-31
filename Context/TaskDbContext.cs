using Microsoft.EntityFrameworkCore;
using TaskApi.Models;


namespace TaskApi.Context
{
    public class TaskDbContext : DbContext
    {

        public TaskDbContext() { }

        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
        }

        public DbSet<Tsk> Tasks { get; set;}
        public DbSet<SubTask> SubTasks { get; set;} 

        public DbSet<User> Users { get; set;}   
    }
}
