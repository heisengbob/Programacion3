using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public DateTime Fnac { get; set; }
        public int ColorFav { get; set; }
        public List<string> MusicaFav { get; set; }
    }   
}
