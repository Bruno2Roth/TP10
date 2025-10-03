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
            List<Categoría> cat = new List<Categoría>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Categorías";
                cat = connection.Query<Categoría>(query).ToList();
            }
            return cat;
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