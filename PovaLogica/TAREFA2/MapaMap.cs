﻿using CsvHelper.Configuration;

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
