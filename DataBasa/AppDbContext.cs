using Microsoft.EntityFrameworkCore;

namespace To_Do_List_Project_.DataAccess
{
    public class AppDBContext : DbContext
    {
        private readonly string _connectionString;

        public AppDBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public virtual DbSet<DoListModel> DoList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
    }
}
