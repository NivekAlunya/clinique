using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;

namespace Clinique.Store
{
    [System.AttributeUsage(System.AttributeTargets.Property|System.AttributeTargets.Class)]
    public class Persist : System.Attribute
    {
        private SqlDbType _dbtype;
        public SqlDbType DbType { get { return _dbtype; } }

        private string _table;
        public string Table { get { return _table; } }

        public Persist(SqlDbType dbtype,bool isPrimaryKey =false, string dbfield = "")
        {
            _dbtype = dbtype;

        }
        public Persist(string table)
        {
            _table = table;
        }
    }
}
