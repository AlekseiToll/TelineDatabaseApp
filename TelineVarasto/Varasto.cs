using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using TelineLib;

using DbConnection;

namespace TelineVarasto
{
    public class Varasto
    {
        private List<TelineOsa> listOsatVarastossa_ = new List<TelineOsa>();
        private DbConnector dbConnector_;

        public Varasto(DbConnector dbConnector)
        {
            dbConnector_ = dbConnector;
        }

        public void LoadTelineOsatData()
        {
            dbConnector_.LoadTelineOsatData(ref listOsatVarastossa_);
        }

        public List<TelineOsa> GetOsatVarastossa()
        {
            return listOsatVarastossa_;
        }
    }
}
