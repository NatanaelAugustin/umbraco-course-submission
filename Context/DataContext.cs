using Microsoft.EntityFrameworkCore;
using umbraco_course_submission.Entities;

namespace umbraco_course_submission.Context
{
    public class DataContext : DbContext
    {

        protected DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<SubsEntity>? Subs { get; set; }
    }
}
