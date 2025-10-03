using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using TP10.Models;

namespace TP10.Models
{
    public class Respuesta
    {
        //ver cual privado y cual publico
        [JsonProperty]
        public int ID { get; set; }
        [JsonProperty]
        public int IDPregunta { get; set; }
        [JsonProperty]
        public int Opcion { get; set; }

        [JsonProperty]
        public string Contenido { get; set; }

        [JsonProperty]
        public bool Correcta { get; set; }

        [JsonProperty]
        public string Foto { get; set; }
        public Respuesta()
        {

        }
    }
}
