using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


using System.Linq;
using System.Threading.Tasks;

namespace ShowroomBackend.Model.DTO
{

    public class DataBaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        //public DataBaseContext()
        //{
        //}

        public DataBaseContext(DbContextOptions options)
           : base(options)
        {

        }
        //public DatabaseContext()
        //{
        //    Database.SetInitializer<DatabaseContext>(new CreateDb());
        //}

        public Microsoft.EntityFrameworkCore.DbSet<Product> Product { set; get; }
        public Microsoft.EntityFrameworkCore.DbSet<Category> Category { set; get; }


    }
}
