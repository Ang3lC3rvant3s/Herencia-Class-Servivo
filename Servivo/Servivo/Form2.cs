using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servivo
{
    public partial class Form2 : Form
    {
        string video;

        public Form2(string link)
        {
            InitializeComponent();
            video = link;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
