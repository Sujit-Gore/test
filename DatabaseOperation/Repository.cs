using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseOperation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        InstituteEntities db;
        public Repository(InstituteEntities db)
        {
            this.db = db;
        }
        public List<TEntity> ExecuteQuery(string spname, object[] parameters)
        {
            List<TEntity> lst = db.Database.SqlQuery<TEntity>(spname, parameters).ToList();
            return lst;
            //List<TEntity> lst = dbobject.Database.SqlQuery<TEntity>(spname, parameters).ToList();
            //return lst;
        }

        public void ExecutrCommand(string spname, object[] parameters)
        {
            db.Database.ExecuteSqlCommand(spname, parameters);
            //dbobject.Database.ExecuteSqlCommand(spname, parameters);
        }
    }
}
