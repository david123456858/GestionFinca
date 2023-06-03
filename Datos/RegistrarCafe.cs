using Entidades;
using System;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace Datos
{
    public class RegistrarCafe:Conexion
    {
        //lleva una secuencia 
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();

        public string RegistradoCafe(Reg_Cafés registrado)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_regcafes", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("RC_cedula_admin", OracleDbType.Varchar2).Value = registrado.CC_ADMIN;
                command.Parameters.Add("RC_cereza_kilos", OracleDbType.Decimal).Value = registrado.Cereza_Kilos;
                command.Parameters.Add("RC_secos_kilos", OracleDbType.Decimal).Value = registrado.Secos_Kilos;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "Registro Guardado en la Base";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<Reg_Cafés> GetAll(string admin)
        {
            try
            {
                List<Reg_Cafés> lista = new List<Reg_Cafés>();
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT * FROM regcafes WHERE CEDULA_ADMIN =:admin", connection);
                command.Parameters.Add(":admin", admin);
                var raid = command.ExecuteReader();
                while (raid.Read())
                {
                    lista.Add(Mappear(raid));
                }
                CerrarBd();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Reg_Cafés Mappear(OracleDataReader linea)
        {
            var cafe = new Reg_Cafés();
            cafe.id_cafe = linea.GetString(0);
            cafe.CC_ADMIN = linea.GetString(1);
            cafe.Cereza_Kilos = linea.GetString(2);
            cafe.Secos_Kilos = linea.GetString(3);
            cafe.Fecha = DateTime.Parse(linea.GetString(4));
            return cafe;
        }
    }
}
