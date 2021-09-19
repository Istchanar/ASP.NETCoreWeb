﻿using MetricsAgent.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.DAL
{
    // маркировочный интерфейс
    // необходим, чтобы проверить работу репозитория на тесте-заглушке

    public class HddMetricsRepository : SQLiteMetricsRepository
    {
        public HddMetricsRepository() 
        {
            _tableName = "hddmetrics";
        }
    }
}
