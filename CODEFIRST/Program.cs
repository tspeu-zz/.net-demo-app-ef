using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CODEFIRST
{

    public class DemoData {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LocalTime { get; set; }
    }

    public class DemoDataContext : DbContext
    {
        public DbSet<DemoData> DemoDatas { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
