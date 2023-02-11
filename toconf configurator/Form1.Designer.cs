namespace toconf_configurator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ciblename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adh = new System.Windows.Forms.TextBox();
            this.adm = new System.Windows.Forms.TextBox();
            this.ads = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decpm = new System.Windows.Forms.TextBox();
            this.dech = new System.Windows.Forms.TextBox();
            this.decm = new System.Windows.Forms.TextBox();
            this.decs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mount = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.obscde = new System.Windows.Forms.TextBox();
            this.ext = new System.Windows.Forms.TextBox();
            this.gen = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.genfi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.empl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nametxt1 = new System.Windows.Forms.TextBox();
            this.up = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Button();
            this.charge = new System.Windows.Forms.Button();
            this.numnom = new System.Windows.Forms.TextBox();
            this.upn = new System.Windows.Forms.Button();
            this.downn = new System.Windows.Forms.Button();
            this.genfiup = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom cible";
            // 
            // ciblename
            // 
            this.ciblename.AccessibleDescription = "";
            this.ciblename.Location = new System.Drawing.Point(140, 16);
            this.ciblename.MaxLength = 7;
            this.ciblename.Name = "ciblename";
            this.ciblename.Size = new System.Drawing.Size(63, 20);
            this.ciblename.TabIndex = 1;
            this.ciblename.Text = "CHM10";
            this.ciblename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ciblename.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD";
            // 
            // adh
            // 
            this.adh.Location = new System.Drawing.Point(178, 120);
            this.adh.MaxLength = 2;
            this.adh.Name = "adh";
            this.adh.Size = new System.Drawing.Size(25, 20);
            this.adh.TabIndex = 5;
            this.adh.Text = "00";
            this.adh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adh.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // adm
            // 
            this.adm.Location = new System.Drawing.Point(209, 120);
            this.adm.MaxLength = 2;
            this.adm.Name = "adm";
            this.adm.Size = new System.Drawing.Size(25, 20);
            this.adm.TabIndex = 6;
            this.adm.Text = "00";
            this.adm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adm.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // ads
            // 
            this.ads.Location = new System.Drawing.Point(240, 120);
            this.ads.MaxLength = 2;
            this.ads.Name = "ads";
            this.ads.Size = new System.Drawing.Size(25, 20);
            this.ads.TabIndex = 7;
            this.ads.Text = "00";
            this.ads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ads.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DEC";
            // 
            // decpm
            // 
            this.decpm.Location = new System.Drawing.Point(147, 146);
            this.decpm.MaxLength = 1;
            this.decpm.Name = "decpm";
            this.decpm.Size = new System.Drawing.Size(25, 20);
            this.decpm.TabIndex = 8;
            this.decpm.Text = "+";
            this.decpm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.decpm.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // dech
            // 
            this.dech.Location = new System.Drawing.Point(178, 146);
            this.dech.MaxLength = 2;
            this.dech.Name = "dech";
            this.dech.Size = new System.Drawing.Size(25, 20);
            this.dech.TabIndex = 9;
            this.dech.Text = "00";
            this.dech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dech.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // decm
            // 
            this.decm.Location = new System.Drawing.Point(209, 146);
            this.decm.MaxLength = 2;
            this.decm.Name = "decm";
            this.decm.Size = new System.Drawing.Size(25, 20);
            this.decm.TabIndex = 10;
            this.decm.Text = "00";
            this.decm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.decm.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // decs
            // 
            this.decs.Location = new System.Drawing.Point(240, 146);
            this.decs.MaxLength = 2;
            this.decs.Name = "decs";
            this.decs.Size = new System.Drawing.Size(25, 20);
            this.decs.TabIndex = 11;
            this.decs.Text = "00";
            this.decs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.decs.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Année";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(140, 42);
            this.year.MaxLength = 4;
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(63, 20);
            this.year.TabIndex = 2;
            this.year.Text = "2023";
            this.year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "(7 caractéres obigatoire)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mois";
            // 
            // mount
            // 
            this.mount.Location = new System.Drawing.Point(140, 68);
            this.mount.MaxLength = 2;
            this.mount.Name = "mount";
            this.mount.Size = new System.Drawing.Size(63, 20);
            this.mount.TabIndex = 3;
            this.mount.Text = "01";
            this.mount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mount.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(140, 94);
            this.day.MaxLength = 2;
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(63, 20);
            this.day.TabIndex = 4;
            this.day.Text = "01";
            this.day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Jour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Obs Code";
            // 
            // obscde
            // 
            this.obscde.Location = new System.Drawing.Point(140, 172);
            this.obscde.MaxLength = 3;
            this.obscde.Name = "obscde";
            this.obscde.Size = new System.Drawing.Size(63, 20);
            this.obscde.TabIndex = 12;
            this.obscde.Text = "M10";
            this.obscde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.obscde.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // ext
            // 
            this.ext.Location = new System.Drawing.Point(26, 198);
            this.ext.Name = "ext";
            this.ext.ReadOnly = true;
            this.ext.Size = new System.Drawing.Size(410, 20);
            this.ext.TabIndex = 22;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(13, 293);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(94, 23);
            this.gen.TabIndex = 18;
            this.gen.Text = "Générer ligne";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(335, 322);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(101, 23);
            this.exit.TabIndex = 20;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // genfi
            // 
            this.genfi.Location = new System.Drawing.Point(13, 322);
            this.genfi.Name = "genfi";
            this.genfi.Size = new System.Drawing.Size(94, 23);
            this.genfi.TabIndex = 19;
            this.genfi.Text = "Générer fichier";
            this.genfi.UseVisualStyleBackColor = true;
            this.genfi.Click += new System.EventHandler(this.genfi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nom fichier";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(165, 256);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(63, 20);
            this.nametxt.TabIndex = 13;
            this.nametxt.Text = "toconf";
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nametxt.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // empl
            // 
            this.empl.Location = new System.Drawing.Point(209, 224);
            this.empl.Name = "empl";
            this.empl.Size = new System.Drawing.Size(174, 20);
            this.empl.TabIndex = 21;
            this.empl.Text = "C:\\Users\\PIN-FERRIER\\Desktop\\";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Emplacement d\'enregistrement";
            // 
            // nametxt1
            // 
            this.nametxt1.Location = new System.Drawing.Point(234, 256);
            this.nametxt1.Name = "nametxt1";
            this.nametxt1.Size = new System.Drawing.Size(31, 20);
            this.nametxt1.TabIndex = 14;
            this.nametxt1.Text = "01";
            this.nametxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nametxt1.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up.Location = new System.Drawing.Point(271, 256);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(25, 21);
            this.up.TabIndex = 15;
            this.up.Text = "+";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "1";
            this.label11.Visible = false;
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down.Location = new System.Drawing.Point(302, 256);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(25, 21);
            this.down.TabIndex = 16;
            this.down.Text = "-";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // charge
            // 
            this.charge.Location = new System.Drawing.Point(335, 293);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(101, 23);
            this.charge.TabIndex = 17;
            this.charge.Text = "Charger réglages";
            this.charge.UseVisualStyleBackColor = true;
            this.charge.Click += new System.EventHandler(this.charge_Click);
            // 
            // numnom
            // 
            this.numnom.Location = new System.Drawing.Point(209, 16);
            this.numnom.Name = "numnom";
            this.numnom.Size = new System.Drawing.Size(31, 20);
            this.numnom.TabIndex = 32;
            this.numnom.Text = "01";
            this.numnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numnom.TextChanged += new System.EventHandler(this.gen_Click);
            // 
            // upn
            // 
            this.upn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upn.Location = new System.Drawing.Point(246, 14);
            this.upn.Name = "upn";
            this.upn.Size = new System.Drawing.Size(25, 21);
            this.upn.TabIndex = 33;
            this.upn.Text = "+";
            this.upn.UseVisualStyleBackColor = true;
            this.upn.Click += new System.EventHandler(this.upn_Click);
            // 
            // downn
            // 
            this.downn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downn.Location = new System.Drawing.Point(277, 14);
            this.downn.Name = "downn";
            this.downn.Size = new System.Drawing.Size(25, 21);
            this.downn.TabIndex = 34;
            this.downn.Text = "-";
            this.downn.UseVisualStyleBackColor = true;
            this.downn.Click += new System.EventHandler(this.downn_Click);
            // 
            // genfiup
            // 
            this.genfiup.Location = new System.Drawing.Point(148, 293);
            this.genfiup.Name = "genfiup";
            this.genfiup.Size = new System.Drawing.Size(123, 23);
            this.genfiup.TabIndex = 35;
            this.genfiup.Text = "Générer fichier + up";
            this.genfiup.UseVisualStyleBackColor = true;
            this.genfiup.Click += new System.EventHandler(this.genfiup_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(132, 322);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(156, 23);
            this.reset.TabIndex = 36;
            this.reset.Text = "Reset num fichier et cible";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 349);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.genfiup);
            this.Controls.Add(this.downn);
            this.Controls.Add(this.upn);
            this.Controls.Add(this.numnom);
            this.Controls.Add(this.charge);
            this.Controls.Add(this.down);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.up);
            this.Controls.Add(this.nametxt1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.empl);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.genfi);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.obscde);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.day);
            this.Controls.Add(this.mount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decs);
            this.Controls.Add(this.decm);
            this.Controls.Add(this.dech);
            this.Controls.Add(this.decpm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ads);
            this.Controls.Add(this.adm);
            this.Controls.Add(this.adh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ciblename);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "toconf Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ciblename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adh;
        private System.Windows.Forms.TextBox adm;
        private System.Windows.Forms.TextBox ads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decpm;
        private System.Windows.Forms.TextBox dech;
        private System.Windows.Forms.TextBox decm;
        private System.Windows.Forms.TextBox decs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mount;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox obscde;
        private System.Windows.Forms.TextBox ext;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button genfi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox empl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nametxt1;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button charge;
        private System.Windows.Forms.TextBox numnom;
        private System.Windows.Forms.Button upn;
        private System.Windows.Forms.Button downn;
        private System.Windows.Forms.Button genfiup;
        private System.Windows.Forms.Button reset;
    }
}

