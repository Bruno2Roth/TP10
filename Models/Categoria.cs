using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP09.Models;
using Newtonsoft.Json;

namespace TP09.Models
{
    public class Categoría
    {
        //ver cual privado y cual público
        [JsonProperty]
        public int ID { get; set; }

        [JsonProperty]
        public string Nombre { get; set; }

        [JsonProperty]
        public string Foto { get; set; }

        public Categoría()
        {

        }
    }
}

