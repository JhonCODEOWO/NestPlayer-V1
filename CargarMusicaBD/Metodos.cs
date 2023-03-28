﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SQLite;

namespace CargarMusicaBD
{
    public class Metodos
    {
        SQLiteConnection cn = new SQLiteConnection("Data Source = DBMusic.db");
        //OleDbConnection cn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = NestPlayer.accdb");
        //SqlConnection cn = new SqlConnection("data source =.; Initial Catalog = DBMusic; Integrated Security = true");

        public DataTable searchFilesInDB(string NombreRecibido)
        {
            try
            {
                string buscar = "SELECT * FROM Cancion WHERE Nombre LIKE @NombreRecibido OR Artistas LIKE @Artistas";

                SQLiteCommand command = new SQLiteCommand(buscar, cn);

                SQLiteParameter parameter = new SQLiteParameter();
                parameter.ParameterName = "@NombreRecibido";
                parameter.DbType = DbType.String;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = "%"+NombreRecibido+"%";
                command.Parameters.Add(parameter);

                parameter = new SQLiteParameter();
                parameter.ParameterName = "@Artistas";
                parameter.DbType = DbType.String;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = "%" + NombreRecibido + "%";
                command.Parameters.Add(parameter);

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                //Console.WriteLine(NombreRecibido.Replace("'", ""));
                //SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Cancion WHERE Nombre LIKE '%" + NombreRecibido + "%'", cn);
                DataTable TableResult = new DataTable();

                dataAdapter.Fill(TableResult);
                dataAdapter = null;
                return TableResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public void PushSongs(string titulo, string Album, string artista, string ruta)
        {
            try
            {

                string insert = "INSERT INTO Cancion VALUES (@Título, @Album, @Artista, @Ruta)";
                cn.Open();
                SQLiteCommand command = new SQLiteCommand(insert, cn);
                command.Parameters.AddWithValue("@Título", titulo);
                command.Parameters.AddWithValue("@Album", Album);
                command.Parameters.AddWithValue("@Artista", artista);
                command.Parameters.AddWithValue("@Ruta", ruta);
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable ShowSongs()
        {
            
            try
            {
                string seleccion = "SELECT * FROM Cancion";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(seleccion, cn);
                DataTable Tablaficheros = new DataTable();

                adapter.Fill(Tablaficheros);
                adapter = null;
                return Tablaficheros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace);
                return null;
            }
        }

        public void EliminarMusica()
        {
            try
            {
                string deleteall = "DELETE FROM Cancion";
                SQLiteCommand command = new SQLiteCommand(deleteall, cn);

                cn.Open();
                command.ExecuteNonQuery();
                cn.Close();
                //MessageBox.Show("Base de datos limpiada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error interno descripción: " + ex.Message + " informa al desarrollador de esto", "Error a nivel de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarCancionSeleccionada(string nombre, string Album, string Artista)
        {
            try
            {
                //string borrarCuando = "DELETE FROM Cancion WHERE Nombre = '" + nombre + "' AND Album = '" + Album + "' AND Artistas = '" + Artista + "' ";
                string borrarCuando = "DELETE FROM Cancion WHERE Nombre = @Nombre AND Album = @Album AND Artistas = @Artistas";
                cn.Open();
                SQLiteCommand command = new SQLiteCommand(borrarCuando, cn);

                SQLiteParameter parameter = new SQLiteParameter();
                parameter.ParameterName = "@Nombre";
                parameter.DbType = DbType.String;
                parameter.Value = nombre;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);

                parameter = new SQLiteParameter();
                parameter.ParameterName = "@Album";
                parameter.DbType = DbType.String;
                parameter.Value = Album;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);

                parameter = new SQLiteParameter();
                parameter.ParameterName = "@Artistas";
                parameter.DbType = DbType.String;
                parameter.Value = Artista;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Se ha eliminado de la base de datos: " + nombre, "Acción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        public string obtenerRuta(string nombre, string album, string artistas)
        {
           
            try
            {
                string letras = null;
                Console.WriteLine("Usando método obtener ruta");
                string FiltrarRuta = "SELECT Ruta FROM Cancion WHERE Nombre = @Nombre AND Album = @Album AND Artistas = @Artistas";
                SQLiteCommand command = new SQLiteCommand(FiltrarRuta, cn);

                SQLiteParameter parameter = new SQLiteParameter();
                parameter.ParameterName = "@Nombre";
                parameter.DbType = DbType.String;
                parameter.Value = nombre;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);

                parameter = new SQLiteParameter();
                parameter.ParameterName = "@Album";
                parameter.DbType = DbType.String;
                parameter.Value = album;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);

                parameter = new SQLiteParameter();
                parameter.ParameterName = "@Artistas";
                parameter.DbType = DbType.String;
                parameter.Value = artistas;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                adapter = null;
                Console.WriteLine(data.Rows.Count);
                foreach (DataRow item in data.Rows)
                {
                    TagLib.File archivo = TagLib.File.Create(item["Ruta"].ToString());
                    if (archivo.Tag.Lyrics != null)
                    {
                        letras = archivo.Tag.Lyrics;
                        break;
                    }
                    else
                    {
                        letras = null;
                        break;
                    }
                }
                return letras;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /*public string obtenerRutaBD(string nombre, string album, string artistas)
        {

        }*/
    }
}
