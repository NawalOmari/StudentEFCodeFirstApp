using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEFCodeFirstApp
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDBConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}
