using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP10.Models;
using Newtonsoft.Json;


namespace TP10.Models
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
        public List<string> ObtenerCategorias()
        {
            List<string> AgregarC = new List<string>();
            Categoria c = new Categoria();
            for (int i = 0; i <= ListaPreguntas.Count(); i++)
            {
                if (AgregarC.Contains(c.Nombre))
                {
                    AgregarC.Add(c.Nombre);
                }
            }
            return AgregarC;
        }
        public void CargarPartida(string username, int categoria)
        {
            InicializarJuego();
            BD.ObtenerPreguntas(categoria);
        }
        public Pregunta ObtenerProximaPregunta()
        {
            ContadorNroPreguntaActual++;
            return PreguntaActual;
        }
        public List<Respuesta> ObtenerProximasRespuestas(int IDPregunta)
        {
            List<Respuesta> ProximasRespuestas = BD.ObtenerRespuestas(IDPregunta);
            return ProximasRespuestas;
        }
        public bool VerificarRespuesta(int IDRespuesta)
        {
            const int Ganar = 1;
            PuntajeActual += Ganar;
            ContadorNroPreguntaActual ++;
            PreguntaActual = ListaPreguntas[ContadorNroPreguntaActual];
            return IDRespuesta.Correcta;
        }

    }
}