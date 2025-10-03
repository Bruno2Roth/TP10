using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP09.Models;
using Newtonsoft.Json;

namespace TP09.Models
{
    public class BD
    {

        public List<Categoría> ObtenerCategorias()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Usuarios WHERE Username = @Username";
                return connection.QueryFirstOrDefault<Usuario>(query, new { Username = username });
            }
            return a;
        }
        public List<Pregunta> ObtenerPreguntas(int Categoria)
        {
            List<Pregunta> a = new List<Pregunta>();
            return a;
        }
        public List<Respuesta> ObtenerRespuestas(int idPregunta)
        {
            List<Respuesta> a = new List<Respuesta>();
            return a;
        }

    }
}