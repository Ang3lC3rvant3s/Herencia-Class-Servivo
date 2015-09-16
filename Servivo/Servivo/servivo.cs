using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Servivo
{
    class servivo
    {
        public string nombre { set; get; }
        public Image imagen { set; get; }

        public servivo(string nombre, Image imagen ) 
        {
            this.nombre = nombre;
            this.imagen = imagen;
        }
        public virtual void accion()
        {
 
        }

    }
}
