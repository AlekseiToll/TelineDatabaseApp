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
        private List<Tyomaa> listTyomaat_ = new List<Tyomaa>();
        private DbConnector dbConnector_;

        public Varasto(DbConnector dbConnector)
        {
            dbConnector_ = dbConnector;
        }

        public void LoadTelineOsatData()
        {
            dbConnector_.LoadTelineOsatData(ref listOsatVarastossa_);
        }

        public void LoadTyomaatData()
        {
            dbConnector_.LoadTyomaatData(ref listTyomaat_);
        }

        public List<TelineOsa> GetOsatVarastossa()
        {
            return listOsatVarastossa_;
        }

        public List<Tyomaa> GetTyomaat()
        {
            return listTyomaat_;
        }
    }
}
