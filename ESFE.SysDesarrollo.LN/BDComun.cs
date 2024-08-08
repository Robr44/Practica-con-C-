﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.SysDesarrollo.LN
{
    public class BDComun
    {
        public const string _stringCnn = @"Data Source=DESKTOP-OC7TLER\SQLEXPRESS;Initial Catalog=BDDesarrollo;Integrated Security=True";

        /// <summary>
        /// Metodo para obtener base de datos.
        /// </summary>
        /// <returns>Devuelve la  conexion</returns>
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_stringCnn);
        }

        public static IDataReader ObtenerCommando(IDbConnection pConexion, string pSql)
        {
            SqlCommand _command = new SqlCommand(pSql, pConexion as SqlConnection);
            return _command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
