using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ConfirmacionEliminarEmpleado : Form
    {
        public ConfirmacionEliminarEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarEmpleado ElimEmp = new EliminarEmpleado();
            ElimEmp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Confirmacion confir = new Confirmacion();
            confir.Show();
            this.Hide();
        }
    }
}
