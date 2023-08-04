using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREFA2
{
    public class MapaMap : ClassMap<Mapa>
    {
        public MapaMap()
        {
            Map(m => m.Local).Name("Local");
            Map(m => m.Populacao).Name("População no último censo");
        }
    }
}
