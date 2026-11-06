using Microsoft.EntityFrameworkCore;
using TaskDesk.Models;

namespace TaskDesk.Data;


public class TaskDeskDbContext : DbContext
{
    public TaskDeskDbContext(
        DbContextOptions<TaskDeskDbContext> options) : base(options)
    {
        
    }

    public DbSet<Ticket> Tickets { get; set; }
}