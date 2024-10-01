using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace ClassLibrary_fot_DB
{
    public class EnglishDbContext: DbContext
    {
        public EnglishDbContext() : base("name=English") { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Answer_mas> Answer_mas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Type_> Types { get; set; }
    }
}
