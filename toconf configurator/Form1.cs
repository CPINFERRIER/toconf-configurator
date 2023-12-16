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
               
        private int currentIndex = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Formulaire initialisé");
            timer1.Interval = 500; // Interval en millisecondes du timer 1 (0,5 seconde)
            timer2.Interval = 2000; // Durée du timer 2 en millisecondes (10 secondes)
            timer1.Tick += Timer1_Tick; // Associe l'événement Tick à la méthode Timer1_Tick
            timer2.Tick += timer2_Tick; // Associe l'événement Tick à la méthode Timer1_Tick
            timer1.Start(); // Démarre le minuteur
            
            // Abonnez-vous à l'événement CheckedChanged de la case à cocher
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
                        
            if (checkBox1.Checked)
            {
                timer2.Enabled = true;
            }

        }

    // executer au chargement du programme
    private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Loaded");
            // Pour loader les paramètres
            string mfileName = "toconf.tcf";

            // Centrer le formulaire sur l'écran
            CenterToScreen();

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

        
        private void gen_Click(object sender, EventArgs e)
        {
           
        }

        // début bouton quitter le programme IMPORTANT
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
            
            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.OK)
            {
                // Enregistrer le contenu de listneocpfait dans un fichier texte
                SaveListneocpfaitToFile();
                // L'utilisateur a appuyé sur le bouton OK, donc quitter l'application
                Application.Exit();
            }
            // Si l'utilisateur a appuyé sur le bouton Annuler, ne rien faire
        }

        //enregidtre la liste dans un fichier texte quand on quitte
        private void SaveListneocpfaitToFile()
        {
            try
            {
                // Générer le nom du fichier basé sur la date du jour
                string fileName = "neocpfait_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

                // Chemin complet du fichier
                string filePath = Path.Combine(Application.StartupPath, fileName);

                // Écrire le contenu de listneocpfait dans le fichier
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in listneocpfait.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement du fichier : " + ex.Message, "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // fin bouton quitter le programme IMPORTANT


        //bouton qui génére le fichier texte
        private void genfi_Click(object sender, EventArgs e)
        {
            
            string fileName = nametxt.Text + nametxt1.Text + ".txt";
            File.WriteAllText(empl.Text + fileName, "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                decs.Text + ".0" + "                      " + obscde.Text + " " );
         
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
                    decs.Text + ".0" + "                      " + obscde.Text + " " );

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
            ciblename.Text = "CHM10";
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
        
        {
            try
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

                    string contentAfterEighthPipe2 = parts[3].Trim();
                    // Découper la partie heure de shoot
                    if (contentAfterEighthPipe.Length >= 6)
                    {
                        string part51 = contentAfterEighthPipe2.Substring(0, 2).Replace(" ", "");
                        string part61 = contentAfterEighthPipe2.Substring(2, 2).Replace(" ", "");

                        //rentre la valeur d'heure de shoot
                        heureshoot.Text = part51 + ":" + part61;
                    }

                    string contentAfterEighthPipe4 = parts[1].Trim();
                    // Découper la partie heure de shoot
                    if (contentAfterEighthPipe.Length >= 6)
                    {
                        string part71 = contentAfterEighthPipe4.Substring(0, 7).Replace(" ", "");


                        //rentre la valeur d'heure de shoot
                        nameneocp.Text = part71;

                    }

                }
            }
            catch (Exception)
            {
                // Gérer l'exception - vous pouvez la journaliser, afficher un message à l'utilisateur, etc.
                MessageBox.Show("Veuillez sélectionner une ligne à charger.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            


        }

        //calcul l'heure TU et la rentre dans un textbox
        public void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime heureTU = DateTime.UtcNow;
            string heureFormattee = heureTU.ToString("HH:mm");
            texttime.Text = heureFormattee;
        }

        // ajoute ce qui est dans les différentes lignes dans la liste d'objets a confirmer dans la nuit et incrémente le numéro de cible
        private void ajoutlist_Click(object sender, EventArgs e)
        {

            string nomNeocp = string.IsNullOrWhiteSpace(nameneocp.Text) ? ciblename.Text + numnom.Text : nameneocp.Text;

            string ligneTexte1 = heureshoot.Text + "     " + nomNeocp + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                                adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                                decs.Text + ".0" + "                      " + obscde.Text + " ";

            listeconfirm.Items.Add(ligneTexte1); // Ajoute la ligne à la ListBox

            int AA = int.Parse(numnom.Text);
            int BB = int.Parse(label11.Text);
            int CC = AA + BB;
            numnom.Text = CC.ToString("D2");                    

        }


        // renvoie la ligne selectionner dans chaque case pour générer le fichier de shoot et incrémente le numéro de fichier de cible
        private void chargvaleur_Click(object sender, EventArgs e)
        {
            if (listeconfirm.SelectedIndex >= 0) // Vérifier si une ligne est sélectionnée
            {
                string selectedLine = listeconfirm.SelectedItem.ToString();                
                string[] param = selectedLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                    heureshoot.Text = param[0];
                    string nomcible = param[1]; // CHM1003
                    string ciblenameValue = nomcible.Substring(0, 5); // CHM10
                    string numnomValue = nomcible.Substring(5); // 03
                    ciblename.Text = ciblenameValue;
                    numnom.Text = numnomValue;
                    string year1 = param[2];
                    string yearok = year1.Substring(2);
                    year.Text = yearok;
                    day.Text = param[3];
                    string mount1 = param[4];
                    string mountok = mount1.Substring(0, 2);
                    mount.Text = mountok;
                    adh.Text = param[5];
                    adm.Text = param[6];
                    string ads1 = param[7];
                    string adsok = ads1.Substring(0, 2);
                    ads.Text = adsok;
                    string dech1 = param[8];
                    string decpmok = dech1.Substring(0, 1);
                    string dechok = dech1.Substring(1, 2);
                    decpm.Text = decpmok;
                    dech.Text = dechok;
                    decm.Text = param[9];
                    string decs1 = param[10];
                    string decsok = decs1.Substring(0, 2);
                    decs.Text = decsok;
                    obscde.Text = param[11];
                    nameneocp.Text = param[1];





                int A = int.Parse(nametxt1.Text);
                int B = int.Parse(label11.Text);
                int C = A + B;
                nametxt1.Text = C.ToString("D2");

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à charger.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Supprimer la dernière ligne ajoutée dans une ListBox
        private void supline_Click(object sender, EventArgs e)
        {           
            if (listeconfirm.Items.Count > 0)
            {
                listeconfirm.Items.RemoveAt(listeconfirm.Items.Count - 1);

                int AA = int.Parse(numnom.Text);
                int BB = int.Parse(label11.Text);
                int CC = AA - BB;
                numnom.Text = CC.ToString("D2");
            }

            else
            {
                MessageBox.Show("Pas de ligne à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void supline1_Click(object sender, EventArgs e)
        {
            // Assurez-vous qu'au moins un élément est sélectionné
            if (listeconfirm.SelectedIndex != -1)
            {
                // Supprimez l'élément sélectionné de la ListBox
                listeconfirm.Items.RemoveAt(listeconfirm.SelectedIndex); 
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Controle les entrée dans la list box de confirmation et déclenche le transfere pour activer le mode automatique 
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            // Si l'état de la case à cocher n'a pas changé, ne faites rien
            if (checkBox1.Checked == timer2.Enabled)
                return;

            // Si la case à cocher est cochée, démarrez le timer, sinon arrêtez-le
            timer2.Enabled = checkBox1.Checked;

            if (checkBox1.Checked)
            {
                Console.WriteLine("Timer Start");
                groupBox3.BackColor = Color.FromArgb(255, 128, 128);
                MessageBox.Show("VOUS VENEZ DE LANCER LE MODE AUTOMATIQUE\n  NE PLUS RIEN TOUCHER SANS L'ARRETER AVANT", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Console.WriteLine("Timer Stop");
                groupBox3.BackColor = SystemColors.Control;
            }
        }


        //mode automatique
        private void VerificationListBox()
        {
            
            Console.WriteLine("Verification list box actif");
            int currentCount = listeconfirm.Items.Count;

            // Si le nombre d'éléments dans la ListBox a changé
            if (currentCount > 0)
            {
                // Mettez à jour l'index du dernier élément
                int lastIndex = currentCount - 1;
                Console.WriteLine(texttime.Text + "  TU");
                // Votre logique de vérification ici
                // Assurez-vous que currentIndex reste dans la plage valide
                if (currentIndex >= 0 && currentIndex <= lastIndex)
                {
                    // Votre logique de vérification ici
                    string premierePartie = (listeconfirm.Items[currentIndex].ToString().Length >= 5)
                        ? listeconfirm.Items[currentIndex].ToString().Substring(0, 5)
                        : listeconfirm.Items[currentIndex].ToString();

                    if (premierePartie == texttime.Text)
                    
                {
                    // Sélectionnez la ligne correspondante dans la ListBox
                    listeconfirm.SelectedIndex = currentIndex;

                    // La partie spécifiée de la ligne correspond à l'heure recherchée
                    // Ajoutez ici le code que vous souhaitez exécuter en cas de correspondance
                    if (listeconfirm.SelectedIndex >= 0) // Vérifier si une ligne est sélectionnée
                    {
                        string selectedLine = listeconfirm.SelectedItem.ToString();
                        string[] param = selectedLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        heureshoot.Text = param[0];
                        string nomcible = param[1]; // CHM1003
                        string ciblenameValue = nomcible.Substring(0, 5); // CHM10
                        string numnomValue = nomcible.Substring(5); // 03
                        ciblename.Text = ciblenameValue;
                        numnom.Text = numnomValue;
                        string year1 = param[2];
                        string yearok = year1.Substring(2);
                        year.Text = yearok;
                        day.Text = param[3];
                        string mount1 = param[4];
                        string mountok = mount1.Substring(0, 2);
                        mount.Text = mountok;
                        adh.Text = param[5];
                        adm.Text = param[6];
                        string ads1 = param[7];
                        string adsok = ads1.Substring(0, 2);
                        ads.Text = adsok;
                        string dech1 = param[8];
                        string decpmok = dech1.Substring(0, 1);
                        string dechok = dech1.Substring(1, 2);
                        decpm.Text = decpmok;
                        dech.Text = dechok;
                        decm.Text = param[9];
                        string decs1 = param[10];
                        string decsok = decs1.Substring(0, 2);
                        decs.Text = decsok;
                        obscde.Text = param[11];
                        nameneocp.Text = param[1];


                            //génére le fichier toconf

                            string fileName = nametxt.Text + nametxt1.Text + ".txt";
                        File.WriteAllText(empl.Text + fileName, "     " + ciblename.Text + numnom.Text + " KC" + year.Text + " " + day.Text + " " + mount.Text + ".00000" + " " +
                            adh.Text + " " + adm.Text + " " + ads.Text + ".00" + " " + decpm.Text + dech.Text + " " + decm.Text + " " +
                            decs.Text + ".0" + "                      " + obscde.Text + " ");

                        // monte de 1 le toconf
                        int A = int.Parse(nametxt1.Text);
                        int B = int.Parse(label11.Text);
                        int C = A + B;
                        nametxt1.Text = C.ToString("D2");

                        // ajoute la cible effectuer dans la liste box fait pour sauvegarder cela visuellement
                        listneocpfait.Items.Add(ciblename.Text + numnom.Text + "  " + heureshoot.Text); // Ajoute la ligne à la ListBox


                            //supprime la ligne aprés génération fichier
                            if (listeconfirm.SelectedIndex != -1)
                        {
                            // Supprimez l'élément sélectionné de la ListBox
                            listeconfirm.Items.RemoveAt(listeconfirm.SelectedIndex);
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Veuillez sélectionner une ligne à charger.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                    //Console.WriteLine("Correspondance trouvée pour l'heure : " + texttime.Text);


                }

                }
                else
                {
                    // Gérez le cas où currentIndex est en dehors de la plage valide
                    // Cela peut inclure la réinitialisation de currentIndex à 0, par exemple
                    currentIndex = 0;
                }

                // Passez à l'élément suivant
                currentIndex++;

                // Si on atteint le dernier élément, réinitialisez l'index pour revenir en haut
                if (currentIndex > lastIndex)
                {
                    currentIndex = 0;
                }
            }
            else
            {
                // Si la première partie ne correspond pas, réinitialisez l'index
                currentIndex = 0;
            }
        }

        //timer du mode automatique
        private void timer2_Tick(object sender, EventArgs e)
        {
            VerificationListBox();
            // Ajoutez un message de débogage
            Console.WriteLine("Timer2 Tick Actif");
        }
        
    }
}

