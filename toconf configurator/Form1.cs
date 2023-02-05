using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toconf_configurator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void gen_Click(object sender, EventArgs e)
        {
            ext.Text = "     " + ciblename.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " + 
                adh.Text + " " + adm.Text + " " + ads.Text +".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text +".0" + "                      " + obscde.Text;
            Clipboard.SetText(ext.Text);
        }

        private void exit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = nametxt.Text + nametxt1.Text + ".txt";
            File.WriteAllText(empl.Text + fileName, "     " + ciblename.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text + ".0" + "                      " + obscde.Text);

            var A = int.Parse(nametxt1.Text);
            var B = int.Parse(label11.Text);
            var C = A + B;
            nametxt1.Text = C.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var A = int.Parse(nametxt1.Text);
            var B = int.Parse(label11.Text);
            var C = A + B;
            nametxt1.Text = C.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var A = int.Parse(nametxt1.Text);
            var B = int.Parse(label11.Text);
            var C = A - B;
            nametxt1.Text = C.ToString();
        }
    }
}
