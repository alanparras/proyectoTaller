﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ToString();

    }
}
