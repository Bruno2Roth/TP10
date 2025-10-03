using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP10.Models;
using Newtonsoft.Json;

namespace TP10.Models
{
    public class Categoria
    {
        //ver cual privado y cual publico
        [JsonProperty]
        public int ID { get; set; }

        [JsonProperty]
        public string Nombre { get; set; }

        [JsonProperty]
        public string Foto { get; set; }

        public Categoria()
        {

        }
    }
}

