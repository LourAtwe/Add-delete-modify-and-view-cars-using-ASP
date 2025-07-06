//we create this file to transfer model in db by using dbcontext
using Microsoft.EntityFrameworkCore;
using MyAdvPro3.Models;

namespace MyAdvPro3.My3Dbcontext
{
    public class ApplicationDb3 : DbContext
    {
        public ApplicationDb3(DbContextOptions options) : base(options)
        {

        }


        public DbSet<CarsModel> Cars { get; set; }// transfer to db
    }
}
//Inside Startup.cs and appsetting.json you must make the connection with database  
