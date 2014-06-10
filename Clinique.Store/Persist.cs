using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;

namespace Clinique.Store
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class Persist : System.Attribute
    {
        private SqlDbType _dbtype;
        public SqlDbType DbType { get { return _dbtype; } }

        public Persist(SqlDbType dbtype,bool isPrimaryKey =false, string dbfield = "")
        {
            _dbtype = dbtype;

        }
    }
}
