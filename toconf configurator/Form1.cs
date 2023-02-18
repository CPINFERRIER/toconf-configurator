using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
                    ciblename.Text = file.ReadLine();
                    numnom.Text = file.ReadLine();
                    nametxt1.Text = file.ReadLine();
                    valmin.Text = file.ReadLine();
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
                    file.WriteLine(numnom.Text);
                    file.WriteLine(nametxt1.Text);
                    file.WriteLine(valmin.Text);
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
                    file.WriteLine(numnom.Text);
                    file.WriteLine(nametxt1.Text);
                    file.WriteLine(valmin.Text);
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

        //bouton + pour monter incrémenter le nom fichier
        private void up_Click(object sender, EventArgs e)
        {
            int A = int.Parse(nametxt1.Text);
            int B = int.Parse(label11.Text);
            int C = A + B;
            nametxt1.Text = C.ToString("D2");

        }

        //bouton - pour décrémenter le nom fichier
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
                    numnom.Text = file.ReadLine();
                    nametxt1.Text = file.ReadLine();
                    valmin.Text = file.ReadLine();
                }
            }
        }

        //incrémente de 1 le nom de cible
        private void upn_Click(object sender, EventArgs e)
        {
            int AA = int.Parse(numnom.Text);
            int BB = int.Parse(label11.Text);
            int CC = AA + BB;
            numnom.Text = CC.ToString("D2");
        }

        //décrémente de 1 le nom de cible
        private void downn_Click(object sender, EventArgs e)
        {
            int AA = int.Parse(numnom.Text);
            int BB = int.Parse(label11.Text);
            int CC = AA - BB;
            numnom.Text = CC.ToString("D2");
        }

        //bouton qui génére le fichier de sortie et qui incrémente de 1 le nom, de 1 le fichier de sortie 
        private void genfiup_Click(object sender, EventArgs e)
        {


            string fileName = nametxt.Text + nametxt1.Text + ".txt";

            string path = empl.Text + fileName;
            bool fileExist = File.Exists(path);
            if (fileExist)
            {

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

                string fileName2 = nametxt.Text + nametxt1.Text + ".txt";

                File.WriteAllText(empl.Text + fileName2, "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                    adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                    decs.Text + ".0" + "                      " + obscde.Text);
            }
            else
            {

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
        }

        // reset les valeur du nom de cible et du nom de fichier de sortie à 01
        private void reset_Click(object sender, EventArgs e)
        {
            nametxt1.Text = "01";
            numnom.Text = "01";
        }

        // bouton + qui incrémente la valeur AD de -XX
        private void adplus_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(adh.Text);
            int num2 = int.Parse(adm.Text);
            int numplus = int.Parse(valmin.Text);

            if (num2 >= 58)
            {
                num2 = 0;
                num1++;
            }
            else
            {
                num2 += numplus;
            }

            if (num1 > 24)
            {
                num1 = 0;
            }

            adh.Text = num1.ToString("D2");
            adm.Text = num2.ToString("D2");
        }

        // bouton + qui décremente la valeur AD de -XX
        private void admoins_Click(object sender, EventArgs e)
        {
            int num3 = int.Parse(adh.Text);
            int num4 = int.Parse(adm.Text);
            int numplus = int.Parse(valmin.Text);

            if (num4 <= 0)
            {
                num4 = 59;
                num3--;
            }
            else
            {
                num4 -= numplus;
            }

            if (num3 < 0)
            {
                num3 = 24;
            }

            adh.Text = num3.ToString("D2");
            adm.Text = num4.ToString("D2");
        }

        //bouton qui génére le fichier de sortie et qui incrémente de 1 le nom, de 1 le fichier de sortie et de +XX en minute la valeur AD
        private void genfiupall_Click(object sender, EventArgs e)
        {
            string fileName = nametxt.Text + nametxt1.Text + ".txt";

            string path = empl.Text + fileName;
            bool fileExist = File.Exists(path);
            if (fileExist)
            {

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

                // monte de +xx la valeur de AD minute
                int num1 = int.Parse(adh.Text);
                int num2 = int.Parse(adm.Text);
                int numplus = int.Parse(valmin.Text);

                if (num2 >= 59)
                {
                    num2 = 0;
                    num1++;
                }
                else
                {
                    num2 += numplus;
                }

                if (num1 > 24)
                {
                    num1 = 0;
                }

                adh.Text = num1.ToString("D2");
                adm.Text = num2.ToString("D2");

                string fileName3 = nametxt.Text + nametxt1.Text + ".txt";

                File.WriteAllText(empl.Text + fileName3, "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text + ".0" + "                      " + obscde.Text);

            }

            else
            {
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

                // monte de +xx la valeur de AD minute
                int num1 = int.Parse(adh.Text);
                int num2 = int.Parse(adm.Text);
                int numplus = int.Parse(valmin.Text);

                if (num2 >= 59)
                {
                    num2 = 0;
                    num1++;
                }
                else
                {
                    num2 += numplus;
                }

                if (num1 > 24)
                {
                    num1 = 0;
                }

                adh.Text = num1.ToString("D2");
                adm.Text = num2.ToString("D2");
                                
            }
        }
    }
}
