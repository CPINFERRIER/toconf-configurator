using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
            string mfileName = "toconf.tcf";
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
            DateTime currentDate = DateTime.Today;
            year.Text = currentDate.ToString("yyyy");
            mount.Text = currentDate.ToString("MM");
            day.Text = currentDate.ToString("dd");
        }

        //bouton qui écrit la ligne pour inspection
        private void gen_Click(object sender, EventArgs e)
        {
            ext.Text = "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " + 
                adh.Text + " " + adm.Text + " " + ads.Text +".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text +".0" + "                      " + obscde.Text + " ";
            Clipboard.SetText(ext.Text);
        }

        // bouton quitter le programme
        private void exit_Click(object sender, EventArgs e)
        {
            // Pour enregistrer les paramétres
            string mfileName = "toconf.tcf";
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
                decs.Text + ".0" + "                      " + obscde.Text + " ");
         
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
            string mfileName = "toconf.tcf";
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
            //verifie si le fichier existe deja 
            string path = empl.Text + fileName;
            bool fileExist = File.Exists(path);
            //si il existe deja
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
                                
            }
            //si il existe pas
            else
            {

                File.WriteAllText(empl.Text + fileName, "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                    adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                    decs.Text + ".0" + "                      " + obscde.Text + " ");

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
            //vérifie si le fichier existe déja 
            string path = empl.Text + fileName;
            bool fileExist = File.Exists(path);
            //si le fichier existe deja
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
                             
            }
            //si le fichier n'existe pas
            else
            {
                File.WriteAllText(empl.Text + fileName, "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text + ".0" + "                      " + obscde.Text + " ");

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

        // Met l'AD à 0 pour le decalage de champ        
        private void resad_Click(object sender, EventArgs e)
        {
            adm.Text = "00";
        }

        // genere et charger le fichier text générer par le script python
        private void chargefichneocp_Click(object sender, EventArgs e)
        {
            //selectionner fichier bat
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Fichiers Batch (*.bat)|*.bat";
            openFileDialog1.Title = "Sélectionner le fichier batch";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string batchFilePath = openFileDialog1.FileName;
                Process.Start(batchFilePath);

                Thread.Sleep(10000);
            }


            //selectionner fichier txt
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cheminFichier = openFileDialog.FileName;
                string contenuFichier = File.ReadAllText(cheminFichier);

                richTextBox1.Text = contenuFichier;
            }
        }


        // choisir l'emplacement d'enregistrement de toconf
        private void emplregister_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                empl.Text = selectedPath + @"\";
            }
        }

        //utiliser pour charger un fichier existant
        private void chargefich2neo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cheminFichier = openFileDialog.FileName;
                string contenuFichier = File.ReadAllText(cheminFichier);

                richTextBox1.Text = contenuFichier;
            }
        }

        //Transfere de la ligne selectionner dans les cases AD et DEC
        private void transf_Click_1(object sender, EventArgs e)
        //private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int lineNumber = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            string selectedLine = richTextBox1.Lines[lineNumber];
            textBox1.Text = selectedLine;

            string[] parts = selectedLine.Split('|');
            if (parts.Length >= 9)
            {
                string contentAfterEighthPipe = parts[8].Trim();
                // Découper la partie AD
                if (contentAfterEighthPipe.Length >= 6)
                {
                    string part1 = contentAfterEighthPipe.Substring(0, 2).Replace(" ", "");
                    string part2 = contentAfterEighthPipe.Substring(2, 3).Replace(" ", "");
                    string part3 = contentAfterEighthPipe.Substring(5, 3).Replace(" ", "");

                    //rentre les valeurs en AD
                    adh.Text = part1;
                    adm.Text = part2;
                    ads.Text = part3;
                }

                string contentAfterEighthPipe1 = parts[9].Trim();
                // Découper la partie DEC
                if (contentAfterEighthPipe.Length >= 6)
                {
                    string part11 = contentAfterEighthPipe1.Substring(0, 1).Replace(" ", "");
                    string part21 = contentAfterEighthPipe1.Substring(1, 3).Replace(" ", "");
                    string part31 = contentAfterEighthPipe1.Substring(4, 3).Replace(" ", "");
                    string part41 = contentAfterEighthPipe1.Substring(6, 3).Replace(" ", "");

                    //rentre les valeurs en DEC
                    decpm.Text = part11;
                    dech.Text = part21;
                    decm.Text = part31;
                    decs.Text = part41;
                }
            }
        }

        
        
    }
}
