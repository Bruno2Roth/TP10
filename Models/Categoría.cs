using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP10.Models;
using Newtonsoft.Json;

namespace TP10.Models
{
    public class Categoría
    {
        [JsonProperty]
        public int ID { get; set; }

        [JsonProperty]
        public string Nombre { get; set; }

        [JsonProperty]
        public string Foto { get; set; }

        public Categoría()
        {

        }

        public Categoría(string nombre)
        {
            ID = -1;
            Nombre = nombre;
        }
    }
}

