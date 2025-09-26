using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP09.Models;
using Newtonsoft.Json;

namespace TP09.Models
{
    public class Juego
    {
        //ver cual privado y cual publico
        [JsonProperty]
        public string Username { get; set; }
        [JsonProperty]
        public int PuntajeActual { get; set; }
        [JsonProperty]
        public int CantidadPreguntasCorrectas { get; set; }
        [JsonProperty]
        public int ContadorNroPreguntaActual { get; set; }
        [JsonProperty]
        public Pregunta PreguntaActual { get; set; }
        [JsonProperty]
        public List<Pregunta> ListaPreguntas { get; set; }
        [JsonProperty]
        public List<Respuesta> ListaRespuestas { get; set; }

        public Juego()
        {

        }
        private void InicializarJuego()
        {
            Username = "";
            PuntajeActual = 0;
            CantidadPreguntasCorrectas = 0;
            ContadorNroPreguntaActual = 0;
            PreguntaActual = null;
            ListaPreguntas = null;
            ListaRespuestas = null;
        }
        public void ObtenerCategorias()
        {
            return //ListaPreguntas.IDCategoria.Nombre;
        }
        public void CargarPartida(string username, int categoria)
        {
            InicializarJuego();
            
            BD bda = HttpContext.Session.GetString("bd");

            bda.ObtenerPreguntas(categoria);
        }
        public void ObtenerProximaPregunta(){
            ContadorNroPreguntaActual++;
        }
    }
}