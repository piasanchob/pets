using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using petsNETV1.Models;

namespace petsNETV1.Controllers
{
    public class AnunciosController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"SELECT nombre,tamaño_id,tipo_id,provincia_id,nivel_id,etapa_id,usuario_id,descripcion,correo,tel FROM Anuncios";
            DataTable table = new DataTable();
            using (var con= new SqlConnection(ConfigurationManager.
                ConnectionStrings["PetsToGoAppDB"].ConnectionString))
                using(var cmd=new SqlCommand(query,con))
            using (var da=new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);




        }

        public string Post(Anuncios anuncio)
        {
            try
            {
                string query = @"INSERT INTO Anuncios VALUES
                (
                '" + anuncio.nombre + @"'
                ,'" + anuncio.tamaño_id + @"'
                ,'" + anuncio.tipo_id + @"'
                ,'" + anuncio.provincia_id + @"'
                ,'" + anuncio.nivel_id + @"'
                ,'" + anuncio.etapa_id + @"'
                ,'" + anuncio.usuario_id + @"'
                ,'" + anuncio.descripcion + @"'
                ,'" + anuncio.correo + @"'
                ,'" + anuncio.tel + @"'
                )";


                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["PetsToGoAppDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Añadido Exitosamente";

            }
            catch (Exception)
            {
                return "Error";
            }
        }

        public string Put(Anuncios anuncio)
        {
            try
            {
                string query = @"UPDATE Anuncios SET 
                
                nombre  =
                '" + anuncio.nombre + @"' 
                ,tamaño_id  =
                '" + anuncio.tamaño_id + @"'
                ,tipo_id  =
                '" + anuncio.tipo_id + @"'
                ,provincia_id  =
                '" + anuncio.provincia_id + @"'
                ,nivel_id  =
                '" + anuncio.nivel_id + @"'
                ,etapa_id  =
                '" + anuncio.etapa_id + @"'
                ,usuario_id  =
                '" + anuncio.usuario_id + @"'
                ,descripcion  =
                '" + anuncio.descripcion + @"'
                ,correo  =
                '" + anuncio.correo + @"'
                ,tel  =
                '" + anuncio.tel + @"'

                WHERE id = '" + anuncio.id + @"'
                )";


                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["PetsToGoAppDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Actualizado Exitosamente";

            }
            catch (Exception)
            {
                return "Error";
            }
        }

        public string Delete(int id)
        {
            try
            {
                string query = @"DELETE FROM Anuncios WHERE id = " + id + @"
                ";


                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["PetsToGoAppDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Eliminado Exitosamente";

            }
            catch (Exception)
            {
                return "Error";
            }
        }

        [Route("api/Anuncios/GetAllAnuncios")]
        [HttpGet]
        public HttpResponseMessage GetAllAnuncios()
        {

            string query = @"SELECT nombre FROM Anuncios ";

            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["PetsToGoAppDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK,table);
        }
    }
}
