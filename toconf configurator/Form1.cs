﻿using System;
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
            var mfileName = "toconf.txt";
            if (File.Exists(mfileName))
            {
                using (var file = new StreamReader(mfileName))
                {
                    empl.Text = file.ReadLine();
                    obscde.Text = file.ReadLine();
                    mount.Text = file.ReadLine();
                    day.Text = file.ReadLine();
                    year.Text = file.ReadLine();
                }
            }
        }

        //bouton qui écrit la ligne pour inspection
        private void gen_Click(object sender, EventArgs e)
        {
            ext.Text = "     " + ciblename.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " + 
                adh.Text + " " + adm.Text + " " + ads.Text +".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text +".0" + "                      " + obscde.Text;
            Clipboard.SetText(ext.Text);
        }

        // bouton quitter le programme
        private void exit_Click(object sender, EventArgs e)
        {
            // Pour enregistrer les paramétres
            var mfileName = "toconf.txt";
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
                }
            }
            // Pour quitter le programme
            Application.Exit();
        }

        //bouton qui génére le fichier texte
        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = nametxt.Text + nametxt1.Text + ".txt";
            File.WriteAllText(empl.Text + fileName, "     " + ciblename.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text + ".0" + "                      " + obscde.Text);

            //monte de + 1 le nom du fichier de sortie
            var A = int.Parse(nametxt1.Text);
            var B = int.Parse(label11.Text);
            var C = A + B;
            nametxt1.Text = C.ToString();
        }

        //bouton + pour monter incrémenter le fichier
        private void button1_Click(object sender, EventArgs e)
        {
            var A = int.Parse(nametxt1.Text);
            var B = int.Parse(label11.Text);
            var C = A + B;
            nametxt1.Text = C.ToString();

        }

        //bouton - pour monter décrémenter le fichier
        private void button3_Click(object sender, EventArgs e)
        {
            var A = int.Parse(nametxt1.Text);
            var B = int.Parse(label11.Text);
            var C = A - B;
            nametxt1.Text = C.ToString();
        }

        //bouton pour recharger les paramétres
        private void charge_Click(object sender, EventArgs e)
        {
            // Pour loader les paramètres
            var mfileName = "toconf.txt";
            if (File.Exists(mfileName))
            {
                using (var file = new StreamReader(mfileName))
                {
                    empl.Text = file.ReadLine();
                    obscde.Text = file.ReadLine();
                    mount.Text = file.ReadLine();
                    day.Text = file.ReadLine();
                    year.Text = file.ReadLine();
                }
            }
        }
    }
}
