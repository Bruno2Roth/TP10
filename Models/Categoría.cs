using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP10.Models;
using Newtonsoft.Json;

namespace TP10.Models
{
    public class Categoria
    {
        [JsonProperty]
        public int ID { get; set; }

        [JsonProperty]
        public string Nombre { get; set; }

        [JsonProperty]
        public string Foto { get; set; }

        public Categoria()
        {

        }

        public Categoria(string nombre)
        {
            ID = -1;
            Nombre = nombre;
        }
    }
}

