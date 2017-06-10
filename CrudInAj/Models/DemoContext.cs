using System.Data.Entity;
namespace CrudInAj.Models
{
    public class DemoContext:DbContext
    {
        public DbSet<Employee> employee { get; set; }
    }
}