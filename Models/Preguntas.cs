using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using TP10.Models;
namespace TP10.Models
{
    public class Pregunta
    {

        //ver cual privado y cual publico
        [JsonProperty]
        public int ID { get; set; }
        [JsonProperty]
        public int IDCategoría { get; set; }
        [JsonProperty]
        public string Enunciado { get; set; }
        [JsonProperty]
        public string Foto { get; set; }
        
        public Pregunta()
        {

        }
    }
}