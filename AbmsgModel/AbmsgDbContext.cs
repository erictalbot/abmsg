using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AbmsgModel.Data;
using AbmsgModel.Migrations;


namespace AbmsgModel
{
    public class AbmsgDbContext : DbContext
    {

        #region properties

        public DbSet<News> News { get; set; }

        #endregion

        #region ctor

        public AbmsgDbContext()
            : base(nameOrConnectionString: "AbmsgNewsEntities")
        {
            Database.SetInitializer<AbmsgDbContext>(new MigrateDatabaseToLatestVersion<AbmsgDbContext, Configuration>());
        }

        #endregion

        #region public methods 

        public virtual int Commit()
        {
            return SaveChanges();
        }

        #endregion 

    }
}
