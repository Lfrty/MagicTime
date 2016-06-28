using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Magic
{
    class daoMagic
    {
        static string BD = "magic.db";

        public SQLiteConnection conexion;
        public bool Conectar()
        {
            string cadenaConexion = "Data Source=" + BD + ";Version=3;" + "FailIfMissing=true;";
            try
            {
                conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;                
            }
        }

        public bool CreaTabla(string nombre)
        {
            string sql = "create table if not exists " + nombre + "(id int, nombre varchar(60), coste varchar(40), texto varchar(255), tipo varchar(50))";
            SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            
            return true;
        }

        public bool DameCartas(int num,Carta unaCarta, string edicion)
        {
            string sql = "insert into " + edicion + " values (" + num + ", '" + unaCarta.Nombre + "', '" + unaCarta.Coste + "', '" + unaCarta.Texto + "', '" + unaCarta.Tipo + "')";
            SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (SQLiteException)
            {
                throw;
            }
        }

        /// <summary>
        /// Realiza búsquedas de DVD en la tabla según la clave
        /// </summary>
        /// <param name="edicion">si es null, lee la tabla entero, de lo contrario solo el codigo indicado</param>
        /// <returns></returns>
        public List<Carta> Seleccionar(string edicion)
        {
            List<Carta> resultado = new List<Carta>();
            string nom="";
            string cost="";
            string ti ="";
            string te="";

            string sql;
                sql = "select nombre,coste,tipo,texto from " + edicion;
            
            SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
            // construimos un datareader y ejecutamos el comando sql

            SQLiteDataReader lector = cmd.ExecuteReader();
            //recuperamos los datos y volcamos en el resultado a devolver

            while (lector.Read())
            {
                nom = lector["nombre"].ToString();
                cost = lector["coste"].ToString();
                ti = lector["tipo"].ToString();
                te = lector["texto"].ToString();
                Carta unaCarta = new Carta(nom, cost, ti, te);
                resultado.Add(unaCarta);                
            }
            lector.Close();
            return resultado;
        }
        
    }
}
