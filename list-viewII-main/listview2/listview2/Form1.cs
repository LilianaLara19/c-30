using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview2
{
    public partial class rbtfrutas: Form

    {
        private ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Center);
        private ListViewGroup carnes = new ListViewGroup("carnes", HorizontalAlignment.Right);
        public rbtfrutas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtfrutas_Load(object sender, EventArgs e)
        {
           

            lstvalimentos.Items.Add(new ListViewItem("manzana", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Pera", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Sandia", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Banana", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Melon", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Ciruela", frutas));

            ListViewItem miElemento = new ListViewItem("pollo", carnes);
            lstvalimentos.Items.Add(miElemento);

            lstvalimentos.Items.Add(new ListViewItem("Res",carnes));
            lstvalimentos.Items.Add(new ListViewItem("Pescado", carnes));
            lstvalimentos.Items.Add(new ListViewItem("Cerdo", carnes));
            lstvalimentos.Items.Add(new ListViewItem("Codorniz", carnes));

            lstvalimentos.Groups.Add(frutas);
            lstvalimentos.Groups.Add(carnes);
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (rdbtnFrutas.Checked == true)
            {
                lstvalimentos.Items.Add(new ListViewItem(txtelemento.Text, frutas));
            }
            if (rdbtnCarnes.Checked == true)
            {
                lstvalimentos.Items.Add(new ListViewItem(txtelemento.Text, carnes));
            }
            }
        }
    }

