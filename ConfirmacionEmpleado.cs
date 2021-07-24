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
    public partial class ConfirmacionEmpleado : Form
    {
        public ConfirmacionEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterfazEmpleado intemp = new InterfazEmpleado();
            intemp.Show();
            this.Hide();
        }
    }
}
