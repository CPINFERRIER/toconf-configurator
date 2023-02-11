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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace toconf_configurator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        // executer au chargement du programme
        private void Form1_Load(object sender, EventArgs e)
        {
            // Pour loader les paramètres
            string mfileName = "toconf.txt";
            if (File.Exists(mfileName))
            {
                using (var file = new StreamReader(mfileName))
                {
                    empl.Text = file.ReadLine();
                    obscde.Text = file.ReadLine();
                    mount.Text = file.ReadLine();
                    day.Text = file.ReadLine();
                    year.Text = file.ReadLine();
                    nametxt.Text = file.ReadLine();
                }
            }
        }

        //bouton qui écrit la ligne pour inspection
        private void gen_Click(object sender, EventArgs e)
        {
            ext.Text = "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " + 
                adh.Text + " " + adm.Text + " " + ads.Text +".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text +".0" + "                      " + obscde.Text;
            Clipboard.SetText(ext.Text);
        }

        // bouton quitter le programme
        private void exit_Click(object sender, EventArgs e)
        {
            // Pour enregistrer les paramétres
            string mfileName = "toconf.txt";
            if (File.Exists(mfileName))
            {
                File.Delete(mfileName);
                using (var file = new StreamWriter(mfileName))
                {
                    file.WriteLine(empl.Text);
                    file.WriteLine(obscde.Text);
                    file.WriteLine(mount.Text);
                    file.WriteLine(day.Text);
                    file.WriteLine(year.Text);
                    file.WriteLine(nametxt.Text);
                    file.WriteLine(ciblename.Text);
                }
            }
            else
            {
                using (var file = new StreamWriter(mfileName))
                {
                    file.WriteLine(empl.Text);
                    file.WriteLine(obscde.Text);
                    file.WriteLine(mount.Text);
                    file.WriteLine(day.Text);
                    file.WriteLine(year.Text);
                    file.WriteLine(nametxt.Text);
                    file.WriteLine(ciblename.Text);
                }
            }
            // Pour quitter le programme
            Application.Exit();
        }

        //bouton qui génére le fichier texte
        private void genfi_Click(object sender, EventArgs e)
        {
            string fileName = nametxt.Text + nametxt1.Text + ".txt";
            File.WriteAllText(empl.Text + fileName, "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text + ".0" + "                      " + obscde.Text);
         
        }

        //bouton + pour monter incrémenter le fichier
        private void up_Click(object sender, EventArgs e)
        {
            int A = int.Parse(nametxt1.Text);
            int B = int.Parse(label11.Text);
            int C = A + B;
            nametxt1.Text = C.ToString("D2");

        }

        //bouton - pour décrémenter le fichier
        private void down_Click(object sender, EventArgs e)
        {
            int A = int.Parse(nametxt1.Text);
            int B = int.Parse(label11.Text);
            int C = A - B;
            nametxt1.Text = C.ToString("D2");
        }

        //bouton pour recharger les paramétres
        private void charge_Click(object sender, EventArgs e)
        {
            // Pour loader les paramètres
            string mfileName = "toconf.txt";
            if (File.Exists(mfileName))
            {
                using (var file = new StreamReader(mfileName))
                {
                    empl.Text = file.ReadLine();
                    obscde.Text = file.ReadLine();
                    mount.Text = file.ReadLine();
                    day.Text = file.ReadLine();
                    year.Text = file.ReadLine();
                    nametxt.Text = file.ReadLine();
                    ciblename.Text = file.ReadLine();
                }
            }
        }

        private void upn_Click(object sender, EventArgs e)
        {
            int AA = int.Parse(numnom.Text);
            int BB = int.Parse(label11.Text);
            int CC = AA + BB;
            numnom.Text = CC.ToString("D2");
        }

        private void downn_Click(object sender, EventArgs e)
        {
            int AA = int.Parse(numnom.Text);
            int BB = int.Parse(label11.Text);
            int CC = AA - BB;
            numnom.Text = CC.ToString("D2");
        }

        private void genfiup_Click(object sender, EventArgs e)
        {
            string fileName = nametxt.Text + nametxt1.Text + ".txt";
            File.WriteAllText(empl.Text + fileName, "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text + ".0" + "                      " + obscde.Text);

            //monte de + 1 le nom du fichier de sortie
            int A = int.Parse(nametxt1.Text);
            int B = int.Parse(label11.Text);
            int C = A + B;
            nametxt1.Text = C.ToString("D2");

            // monte de +1 le nom de la cible
            int AA = int.Parse(numnom.Text);
            int BB = int.Parse(label11.Text);
            int CC = AA + BB;
            numnom.Text = CC.ToString("D2");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            nametxt1.Text = "01";
            numnom.Text = "01";
        }
    }
}
