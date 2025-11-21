using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pokemon
{
    internal class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, Descripcion, UrlImagen From POKEMONS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();      //Acá se crea cada vez que el while da true (cada vez que hay algo para leer)
                                                      //una nueva instancia de Pokemon reutilizando la variable aux
                    aux.Numero = lector.GetInt32(0);  //donde se guardan todos los datos mencionados con un punto (nombre, descripción y número)
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"]; //--> este hay que agregarlo como aux

                    lista.Add(aux); ;
                }
                    
                return lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha habido un error con la base de datos.", "Advertencia");
                throw ex;
            }
            finally { conexion.Close(); }

        } 
    }
}
