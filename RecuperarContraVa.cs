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
    public partial class RecuperarContraVa : Form
    {
        public RecuperarContraVa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterfazEmpleado Int = new InterfazEmpleado();
            Int.Show();
            this.Hide();
        }
    }
}
