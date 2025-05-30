using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_C_29
{
    public partial class Form1: Form
    {
        private int indice;
        public Form1()
        {
            InitializeComponent();
            indice = 0;
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 8)
                indice = 0;

            lblFoto.ImageIndex = indice;


            pcbimagen.Image=imglFotos.Images[indice];



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcbimagen.Image = imglFotos.Images[0];
        }
    }
}
