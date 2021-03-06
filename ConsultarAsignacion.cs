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
    public partial class ConsultarAsignacion : Form
    {
        public ConsultarAsignacion()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int lx, ly;
            int sw, sh;

            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InterfazAdmin IntAdm = new InterfazAdmin();
            IntAdm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroAsignaciones Rew = new RegistroAsignaciones();
            Rew.Show();
            this.Hide();
        }
    }
}
