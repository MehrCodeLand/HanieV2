using HanieV2.Data.Model.PaintsObj;
using Microsoft.EntityFrameworkCore;

namespace HanieV2.Data.DbFile
{
    public class MyDb : DbContext
    {
        public MyDb( DbContextOptions<MyDb> options ) : base( options )
        {

        }

        public DbSet<Paint> Paints { get; set; }
    }
}
