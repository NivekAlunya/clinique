using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;

namespace Clinique.Tools
{
    [System.AttributeUsage(System.AttributeTargets.Property|System.AttributeTargets.Class)]
    public class Persist : System.Attribute
    {
        private SqlDbType _dbtype;
        public SqlDbType DbType { get { return _dbtype; } }

        private FieldBehaviour _behaviour;
        public FieldBehaviour Behaviour { get { return _behaviour; } }

        private string _field;
        public string Field { get { return _field; } }

        private string _table;
        public string Table { get { return _table; } }
        public enum FieldBehaviour{
            common = 0,
            pk = 1,
            autoincrement = 2
        }
        public Persist(SqlDbType dbtype, FieldBehaviour behaviour = FieldBehaviour.common, string dbfield = "")
        {
            _dbtype = dbtype;
            _behaviour = behaviour;
            _field = dbfield;
        }

        public Persist(string table)
        {
            _table = table;
        }
    }
}
