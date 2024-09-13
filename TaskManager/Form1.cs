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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] proc;
        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process p in proc)
                listBox1.Items.Add(p.ProcessName);
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                proc[listBox1.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void correrNuevaTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(RunTarea frm=new RunTarea()) 
            { 
                if (frm.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
            }
        }
    }
}
