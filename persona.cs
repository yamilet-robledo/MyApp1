using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class persona
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }

        public persona(int id, string nom, string tel)
        {
            Id = id;
            nombre = nom;
            telefono = tel;  
        }
    }
}
