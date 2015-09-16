﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Servivo
{
    class Leon : servivo
    {
        public Leon(string nombre, Image imagen)
            : base(nombre, imagen)
        { }
        public override void accion()
        {
            SoundPlayer soni = new SoundPlayer("Leon.wav");
            soni.Play();
        }
    }
}
