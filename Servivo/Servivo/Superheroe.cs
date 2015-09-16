using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Servivo
{
    class Superheroe :servivo
    {
        private string video;
        private Form formulario;

        public Superheroe(string nombre, Image foto, string video, Form formulario)
            : base(nombre, foto)
        {
            this.video = video;
            this.formulario=formulario;
        }

        public override void accion() 
        {
            Form2 form = new Form2(video);
            form.MdiParent = formulario;
            form.Show();
        }

    }
}
