
using System;
using System.Data.Entity;
using System.Linq;
using AbmsgModel;
using AbmsgModel.Data;


namespace AbmsgModel.Repositories
{
    /// <summary>
    /// TaskRepository override the DefaultRepository to provide only methods that Tasks needs (Override and the throw exception )
    /// and other that DefaultRepository would not provide.
    /// </summary>
    public class NewsRepository : DefaultRepository<News>, INewsRepository
    {
        public NewsRepository(DbContext context) : base(context) { }

        public override IQueryable<News> GetAll()
        {
            return DbSet;
        }
    }
}
