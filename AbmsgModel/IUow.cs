using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbmsgModel.Repositories;

namespace AbmsgModel
{
    public interface IUow
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        INewsRepository News { get; }
    }
}
