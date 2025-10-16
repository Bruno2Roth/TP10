using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP10.Models;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;
using Dapper;

namespace TP10.Models
{
    public static class BD
    {
        private static string _connectionString = "Server=localhost;Database=preguntadORT;Integrated Security=True;TrustServerCertificate=True;";

        public static List<Categoría> ObtenerCategorias()
        {
            List<Categoría> cat = new List<Categoría>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Categorias";
                cat = connection.Query<Categoría>(query).ToList();
            }
            return cat;
        }
        public static List<Pregunta> ObtenerPreguntas(int Categoria)
        {
            List<Pregunta> preg = new List<Pregunta>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Preguntas WHERE IDCategoría = @pCat";

                if (Categoria == -1)
                {
                    query = "SELECT * FROM Pregunta";
                }

                preg = connection.Query<Pregunta>(query, new { pCat = Categoria }).ToList();

            }

            return preg;
        }
        public static List<Respuesta> ObtenerRespuestas(int idPregunta)
        {
            List<Respuesta> ans = new List<Respuesta>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Opciones WHERE IDPregunta = @pCat";
                ans = connection.Query<Respuesta>(query, new { pCat = idPregunta }).ToList();

            }

            return ans;
        }

    }
}