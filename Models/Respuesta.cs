using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP09.Models;
using Newtonsoft.Json;

namespace TP09.Models
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
