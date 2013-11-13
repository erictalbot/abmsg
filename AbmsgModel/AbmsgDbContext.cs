using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AbmsgModel.Data;


namespace AbmsgModel
{
    public class AbmsgDbContext : DbContext
    {

        #region properties

        public DbSet<ANew> News { get; set; }

        #endregion

        #region ctor

        public AbmsgDbContext()
            : base(nameOrConnectionString: "AbmsgNewsEntities")
        {
            Database.SetInitializer<AbmsgDbContext>(new CreateDatabaseIfNotExists<AbmsgDbContext>());
        }

        #endregion


    }
}
