using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Net;
using System.Data.SqlClient;
using programacionejerc5clases;

namespace interfacesejerc1
{
    internal class ConnectSQL
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comand = new SqlCommand();
        

        public List<Docente> ListarDocentes() 
        {
            List<Docente> listDocentes = new List<Docente>();
            conexion.ConnectionString = "data source=MauriPC; initial catalog=Empleados_DB; integrated security=sspi";
            comand.CommandType = System.Data.CommandType.Text;
            comand.CommandText = "select * from Docentess";
            comand.Connection = conexion;
            conexion.Open();
            SqlDataReader reader;
            reader = comand.ExecuteReader();
            while (reader.Read()) 
            {
                Docente aux = new Docente();
                aux.Puesto = reader.GetString(1);
                aux.Name = reader.GetString(2);
                aux.Antiguedad = reader.GetInt32(3);
                aux.Salario = reader.GetInt32(4);
                aux.Edad = reader.GetInt32(5);
                listDocentes.Add(aux);
                conexion.Close();

            }


            return listDocentes;

        }

     
        
       
    }
}
