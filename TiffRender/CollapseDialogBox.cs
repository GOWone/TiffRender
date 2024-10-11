using System;
using System.Windows.Forms;

namespace TiffRender
{
    public partial class CollapseDialogBox : Form
    {
        public CollapseDialogBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = !this.panel1.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = !this.panel2.Visible;
        }
    }
}
