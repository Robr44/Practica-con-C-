using ESFE.SysDesarrollo.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.SysDesarrollo.LN
{
    public class MarcaBL
    {
        public int InsertarMarca(Marca pMarca)
        {
            //Insertar
            using (IDbConnection _Conn = BDComun.ObtenerConexion())
            {
                _Conn.Open();
                SqlCommand _Command = new SqlCommand("InsertarMarca", _Conn as SqlConnection);
                _Command.CommandType = CommandType.StoredProcedure;

                _Command.Parameters.Add(new SqlParameter("@Nombre", pMarca.Nombre));
                _Command.Parameters.Add(new SqlParameter("@Descripcion", pMarca.Descripcion));
                _Command.Parameters.Add(new SqlParameter("@RegMarca", pMarca.RegMarca));

                int _resultado = _Command.ExecuteNonQuery();
                _Conn.Close();
                return _resultado;
            }
        }

        //otro metodo Seleccionar todo
        public List<Marca> ObtenerMarcas()
        {
            List<Marca> _marcas = new List<Marca>();


            //la lista es para tener todos los valores necesitamos que devuelva todo lo que esta en la tabla
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                SqlCommand _command = new SqlCommand("SELECT * FROM Marca", _conn as SqlConnection);
                SqlDataReader _reader = _command.ExecuteReader();//esto se lo se usa con el select

                while (_reader.Read())
                {
                    Marca _marca = new Marca
                    {

                        //esto es un casteo esto pasar parametros al tipo de datos que va a leer
                        IdMarca = (int)_reader.GetSqlInt32(0),
                        Nombre = _reader.GetString(1),
                        Descripcion = _reader.GetString(2),
                        RegMarca = (int)_reader.GetSqlInt32(3)
                    };

                    _marcas.Add(_marca);
                }

                _reader.Close();
                _conn.Close();
                return _marcas;

            }
        }

        //Buscar por nombre
        public List<Marca> ObtenerMarcaNombre(string pNombre)
        {
            List<Marca> _marcas = new List<Marca>();


            //la lista es para tener todos los valores necesitamos que devuelva todo lo que esta en la tabla
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                SqlCommand _command = new SqlCommand("BuscarMarcaNombre", _conn as SqlConnection);
                _command.CommandType = CommandType.StoredProcedure;

                _command.Parameters.Add(new SqlParameter("@Nombre", pNombre));

                SqlDataReader _reader = _command.ExecuteReader();//esto se lo se usa con el select

                while (_reader.Read())
                {
                    Marca _marca = new Marca
                    {

                        //esto es un casteo esto pasar parametros al tipo de datos que va a leer
                        IdMarca = (int)_reader.GetSqlInt32(0),
                        Nombre = _reader.GetString(1),
                        Descripcion = _reader.GetString(2),
                        RegMarca = (int)_reader.GetSqlInt32(3)
                    };

                    _marcas.Add(_marca);
                }

                _reader.Close();
                _conn.Close();
                return _marcas;

            }
        }

        //metodo actualizar 
        public int ActualizarMarca(Marca pMarca)
        {
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                SqlCommand _command = new SqlCommand("ActualizarMarca", _conn as SqlConnection);
                _command.CommandType = CommandType.StoredProcedure;

                _command.Parameters.Add(new SqlParameter("@IdMarca", pMarca.IdMarca));
                _command.Parameters.Add(new SqlParameter("@Nombre", pMarca.Nombre));
                _command.Parameters.Add(new SqlParameter("@Descripcion", pMarca.Descripcion));
                _command.Parameters.Add(new SqlParameter("@RegMarca", pMarca.RegMarca));

                int _resultado = _command.ExecuteNonQuery();

                _conn.Close();
                return _resultado;
            }
        }

        public int EliminarMarca(Marca pMarca)
        {
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                using (SqlCommand _command = new SqlCommand("EliminarMarca", _conn as SqlConnection))
                {
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@IdMarca", pMarca);

                    int resultado = _command.ExecuteNonQuery();
                    return resultado;
                }
            }
        }
    }

}
















