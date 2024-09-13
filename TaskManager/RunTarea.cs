using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class RunTarea : Form
    {
        public RunTarea()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEjecutar.Text))
            {
                try
                {
                   Process proc = new Process();
                    proc.StartInfo.FileName = txtEjecutar.Text;
                    proc.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
