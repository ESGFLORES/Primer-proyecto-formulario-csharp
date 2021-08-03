using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_proyecto_formulario_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEduardoGarcia.Text = "Eduardo Garcia";
            lblMiguelRuiz.Text = "Miguel Ruiz";
            lblDimasRosales.Text = "Dimas Rosales";
            lblKleverMontano.Text = "Klever Montano";
            lblEmelyRodriguez.Text= "Emely Rodriguez";
            lblMiguelQuinteros.Text = "Miguel Quinteros";
        }

        private void lblEmelyRodriguez_Click(object sender, EventArgs e)
        {

        }
    }
}
