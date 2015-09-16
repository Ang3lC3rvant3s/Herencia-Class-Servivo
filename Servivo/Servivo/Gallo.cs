using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;
namespace Servivo
{
    class Gallo : servivo
    {
        public Gallo(string nombre, Image imagen)
            : base(nombre, imagen)
        { }
        public override void accion()
        {
            SoundPlayer soni = new SoundPlayer("Gallo.wav");
            soni.Play();
        }
    }
}
