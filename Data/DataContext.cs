using Microsoft.EntityFrameworkCore;

namespace sgs.Articles
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>) { }
    }
}