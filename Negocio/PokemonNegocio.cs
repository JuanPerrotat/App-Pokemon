using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Security.Cryptography.X509Certificates;
using Negocio;

namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad from Pokemons P, Elementos E, Elementos D  where E.Id = P.IdTipo  and D.Id = P.IdDebilidad";
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

                   
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"]; //--> este hay que agregarlo como aux


                    aux.Tipo = new Elemento(); //--> Constructor del objeto elemento con un tipo
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();//--> Constructor del objeto elemento con una debilidad
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux); ;
                }
                    
                return lista;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
            finally { conexion.Close(); }      
        } 
        public void agregar (Pokemon nuevo)
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values (" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1, @IdTipo, @IdDebilidad, @UrlImagen)");
                acceso.setearParametro("@IdTipo", nuevo.Tipo.Id);
                acceso.setearParametro("@IdDebilidad", nuevo.Debilidad.Id);
                acceso.setearParametro("@UrlImagen", nuevo.UrlImagen);
                acceso.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }
    }
}
