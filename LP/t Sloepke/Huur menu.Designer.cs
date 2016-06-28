namespace t_Sloepke
{
    partial class Huur_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotenL = new System.Windows.Forms.ListBox();
            this.BotenR = new System.Windows.Forms.ListBox();
            this.lblBotenL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BootNR = new System.Windows.Forms.Button();
            this.BootNL = new System.Windows.Forms.Button();
            this.ArtL = new System.Windows.Forms.ListBox();
            this.ArtR = new System.Windows.Forms.ListBox();
            this.ArtNR = new System.Windows.Forms.Button();
            this.ArtNL = new System.Windows.Forms.Button();
            this.lblArtL = new System.Windows.Forms.Label();
            this.lblArtR = new System.Windows.Forms.Label();
            this.lblbudget = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.NumericUpDown();
            this.kostenboot = new System.Windows.Forms.Label();
            this.kostenart = new System.Windows.Forms.Label();
            this.lblkostenboot = new System.Windows.Forms.Label();
            this.lblkostenart = new System.Windows.Forms.Label();
            this.DateT = new System.Windows.Forms.DateTimePicker();
            this.DateV = new System.Windows.Forms.DateTimePicker();
            this.GBPeriode = new System.Windows.Forms.GroupBox();
            this.lbldagen = new System.Windows.Forms.Label();
            this.bttnBdagen = new System.Windows.Forms.Button();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblvanaf = new System.Windows.Forms.Label();
            this.IJsselmeercheck = new System.Windows.Forms.CheckBox();
            this.Noordzeecheck = new System.Windows.Forms.CheckBox();
            this.varen = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnBereken = new System.Windows.Forms.Button();
            this.lblaantalf = new System.Windows.Forms.Label();
            this.lblTotpd = new System.Windows.Forms.Label();
            this.lblSluis = new System.Windows.Forms.Label();
            this.lblTotb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaakHC = new System.Windows.Forms.Button();
            this.txtnaam = new System.Windows.Forms.TextBox();
            this.lblnaam = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.bttnOverzicht = new System.Windows.Forms.Button();
            this.bttninuitlog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).BeginInit();
            this.GBPeriode.SuspendLayout();
            this.varen.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotenL
            // 
            this.BotenL.FormattingEnabled = true;
            this.BotenL.Location = new System.Drawing.Point(11, 61);
            this.BotenL.Name = "BotenL";
            this.BotenL.Size = new System.Drawing.Size(107, 134);
            this.BotenL.TabIndex = 0;
            this.BotenL.Click += new System.EventHandler(this.BotenL_Click);
            this.BotenL.DoubleClick += new System.EventHandler(this.BotenL_DoubleClick);
            // 
            // BotenR
            // 
            this.BotenR.FormattingEnabled = true;
            this.BotenR.Location = new System.Drawing.Point(180, 61);
            this.BotenR.Name = "BotenR";
            this.BotenR.Size = new System.Drawing.Size(107, 134);
            this.BotenR.TabIndex = 1;
            this.BotenR.Click += new System.EventHandler(this.BotenR_Click);
            // 
            // lblBotenL
            // 
            this.lblBotenL.AutoSize = true;
            this.lblBotenL.Location = new System.Drawing.Point(8, 42);
            this.lblBotenL.Name = "lblBotenL";
            this.lblBotenL.Size = new System.Drawing.Size(99, 13);
            this.lblBotenL.TabIndex = 2;
            this.lblBotenL.Text = "Boten beschikbaar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geselecteerde boten:";
            // 
            // BootNR
            // 
            this.BootNR.Location = new System.Drawing.Point(124, 95);
            this.BootNR.Name = "BootNR";
            this.BootNR.Size = new System.Drawing.Size(51, 23);
            this.BootNR.TabIndex = 4;
            this.BootNR.Text = ">>";
            this.BootNR.UseVisualStyleBackColor = true;
            this.BootNR.Click += new System.EventHandler(this.BootNR_Click);
            // 
            // BootNL
            // 
            this.BootNL.Location = new System.Drawing.Point(124, 135);
            this.BootNL.Name = "BootNL";
            this.BootNL.Size = new System.Drawing.Size(51, 23);
            this.BootNL.TabIndex = 5;
            this.BootNL.Text = "<<";
            this.BootNL.UseVisualStyleBackColor = true;
            this.BootNL.Click += new System.EventHandler(this.BootNL_Click);
            // 
            // ArtL
            // 
            this.ArtL.FormattingEnabled = true;
            this.ArtL.Location = new System.Drawing.Point(11, 229);
            this.ArtL.Name = "ArtL";
            this.ArtL.Size = new System.Drawing.Size(107, 134);
            this.ArtL.TabIndex = 6;
            this.ArtL.Click += new System.EventHandler(this.ArtL_Click);
            // 
            // ArtR
            // 
            this.ArtR.FormattingEnabled = true;
            this.ArtR.Location = new System.Drawing.Point(179, 229);
            this.ArtR.Name = "ArtR";
            this.ArtR.Size = new System.Drawing.Size(107, 134);
            this.ArtR.TabIndex = 7;
            this.ArtR.Click += new System.EventHandler(this.ArtR_Click);
            this.ArtR.DoubleClick += new System.EventHandler(this.ArtR_DoubleClick);
            // 
            // ArtNR
            // 
            this.ArtNR.Location = new System.Drawing.Point(124, 263);
            this.ArtNR.Name = "ArtNR";
            this.ArtNR.Size = new System.Drawing.Size(51, 23);
            this.ArtNR.TabIndex = 8;
            this.ArtNR.Text = ">>";
            this.ArtNR.UseVisualStyleBackColor = true;
            this.ArtNR.Click += new System.EventHandler(this.ArtNR_Click);
            // 
            // ArtNL
            // 
            this.ArtNL.Location = new System.Drawing.Point(124, 303);
            this.ArtNL.Name = "ArtNL";
            this.ArtNL.Size = new System.Drawing.Size(51, 23);
            this.ArtNL.TabIndex = 9;
            this.ArtNL.Text = "<<";
            this.ArtNL.UseVisualStyleBackColor = true;
            this.ArtNL.Click += new System.EventHandler(this.ArtNL_Click);
            // 
            // lblArtL
            // 
            this.lblArtL.AutoSize = true;
            this.lblArtL.Location = new System.Drawing.Point(8, 213);
            this.lblArtL.Name = "lblArtL";
            this.lblArtL.Size = new System.Drawing.Size(112, 13);
            this.lblArtL.TabIndex = 10;
            this.lblArtL.Text = "Artikelen beschikbaar:";
            // 
            // lblArtR
            // 
            this.lblArtR.AutoSize = true;
            this.lblArtR.Location = new System.Drawing.Point(171, 213);
            this.lblArtR.Name = "lblArtR";
            this.lblArtR.Size = new System.Drawing.Size(122, 13);
            this.lblArtR.TabIndex = 11;
            this.lblArtR.Text = "Geselecteerde artikelen:";
            // 
            // lblbudget
            // 
            this.lblbudget.AutoSize = true;
            this.lblbudget.Location = new System.Drawing.Point(11, 13);
            this.lblbudget.Name = "lblbudget";
            this.lblbudget.Size = new System.Drawing.Size(44, 13);
            this.lblbudget.TabIndex = 12;
            this.lblbudget.Text = "Budget:";
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(55, 11);
            this.budget.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(120, 20);
            this.budget.TabIndex = 13;
            // 
            // kostenboot
            // 
            this.kostenboot.AutoSize = true;
            this.kostenboot.Location = new System.Drawing.Point(306, 61);
            this.kostenboot.Name = "kostenboot";
            this.kostenboot.Size = new System.Drawing.Size(139, 13);
            this.kostenboot.TabIndex = 14;
            this.kostenboot.Text = "Kosten voor boten per dag: ";
            // 
            // kostenart
            // 
            this.kostenart.AutoSize = true;
            this.kostenart.Location = new System.Drawing.Point(306, 245);
            this.kostenart.Name = "kostenart";
            this.kostenart.Size = new System.Drawing.Size(152, 13);
            this.kostenart.TabIndex = 15;
            this.kostenart.Text = "Kosten voor artikelen per dag: ";
            // 
            // lblkostenboot
            // 
            this.lblkostenboot.AutoSize = true;
            this.lblkostenboot.Location = new System.Drawing.Point(309, 95);
            this.lblkostenboot.Name = "lblkostenboot";
            this.lblkostenboot.Size = new System.Drawing.Size(25, 13);
            this.lblkostenboot.TabIndex = 16;
            this.lblkostenboot.Text = "€0,-";
            // 
            // lblkostenart
            // 
            this.lblkostenart.AutoSize = true;
            this.lblkostenart.Location = new System.Drawing.Point(309, 290);
            this.lblkostenart.Name = "lblkostenart";
            this.lblkostenart.Size = new System.Drawing.Size(25, 13);
            this.lblkostenart.TabIndex = 17;
            this.lblkostenart.Text = "€0,-";
            // 
            // DateT
            // 
            this.DateT.Location = new System.Drawing.Point(6, 96);
            this.DateT.MinDate = new System.DateTime(2016, 6, 23, 0, 0, 0, 0);
            this.DateT.Name = "DateT";
            this.DateT.Size = new System.Drawing.Size(200, 20);
            this.DateT.TabIndex = 18;
            this.DateT.Value = new System.DateTime(2016, 6, 23, 11, 0, 24, 0);
            // 
            // DateV
            // 
            this.DateV.Location = new System.Drawing.Point(6, 46);
            this.DateV.MinDate = new System.DateTime(2016, 6, 23, 0, 0, 0, 0);
            this.DateV.Name = "DateV";
            this.DateV.Size = new System.Drawing.Size(200, 20);
            this.DateV.TabIndex = 19;
            // 
            // GBPeriode
            // 
            this.GBPeriode.Controls.Add(this.lbldagen);
            this.GBPeriode.Controls.Add(this.bttnBdagen);
            this.GBPeriode.Controls.Add(this.lblTot);
            this.GBPeriode.Controls.Add(this.lblvanaf);
            this.GBPeriode.Controls.Add(this.DateT);
            this.GBPeriode.Controls.Add(this.DateV);
            this.GBPeriode.Location = new System.Drawing.Point(486, 42);
            this.GBPeriode.Name = "GBPeriode";
            this.GBPeriode.Size = new System.Drawing.Size(218, 231);
            this.GBPeriode.TabIndex = 20;
            this.GBPeriode.TabStop = false;
            this.GBPeriode.Text = "Huur Periode";
            // 
            // lbldagen
            // 
            this.lbldagen.AutoSize = true;
            this.lbldagen.Location = new System.Drawing.Point(7, 156);
            this.lbldagen.Name = "lbldagen";
            this.lbldagen.Size = new System.Drawing.Size(76, 13);
            this.lbldagen.TabIndex = 23;
            this.lbldagen.Text = "Aantal dagen: ";
            // 
            // bttnBdagen
            // 
            this.bttnBdagen.Location = new System.Drawing.Point(6, 193);
            this.bttnBdagen.Name = "bttnBdagen";
            this.bttnBdagen.Size = new System.Drawing.Size(111, 23);
            this.bttnBdagen.TabIndex = 22;
            this.bttnBdagen.Text = "Bereken dagen";
            this.bttnBdagen.UseVisualStyleBackColor = true;
            this.bttnBdagen.Click += new System.EventHandler(this.bttnBdagen_Click);
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(7, 80);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(26, 13);
            this.lblTot.TabIndex = 21;
            this.lblTot.Text = "Tot:";
            // 
            // lblvanaf
            // 
            this.lblvanaf.AutoSize = true;
            this.lblvanaf.Location = new System.Drawing.Point(7, 27);
            this.lblvanaf.Name = "lblvanaf";
            this.lblvanaf.Size = new System.Drawing.Size(38, 13);
            this.lblvanaf.TabIndex = 20;
            this.lblvanaf.Text = "Vanaf:";
            // 
            // IJsselmeercheck
            // 
            this.IJsselmeercheck.AutoSize = true;
            this.IJsselmeercheck.Location = new System.Drawing.Point(6, 19);
            this.IJsselmeercheck.Name = "IJsselmeercheck";
            this.IJsselmeercheck.Size = new System.Drawing.Size(75, 17);
            this.IJsselmeercheck.TabIndex = 21;
            this.IJsselmeercheck.Text = "IJsselmeer";
            this.IJsselmeercheck.UseVisualStyleBackColor = true;
            // 
            // Noordzeecheck
            // 
            this.Noordzeecheck.AutoSize = true;
            this.Noordzeecheck.Location = new System.Drawing.Point(6, 37);
            this.Noordzeecheck.Name = "Noordzeecheck";
            this.Noordzeecheck.Size = new System.Drawing.Size(72, 17);
            this.Noordzeecheck.TabIndex = 22;
            this.Noordzeecheck.Text = "Noordzee";
            this.Noordzeecheck.UseVisualStyleBackColor = true;
            // 
            // varen
            // 
            this.varen.Controls.Add(this.label2);
            this.varen.Controls.Add(this.IJsselmeercheck);
            this.varen.Controls.Add(this.Noordzeecheck);
            this.varen.Location = new System.Drawing.Point(486, 279);
            this.varen.Name = "varen";
            this.varen.Size = new System.Drawing.Size(218, 84);
            this.varen.TabIndex = 25;
            this.varen.TabStop = false;
            this.varen.Text = "Waar gaat u varen?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "€2,- per dag per optie";
            // 
            // bttnBereken
            // 
            this.bttnBereken.Location = new System.Drawing.Point(486, 406);
            this.bttnBereken.Name = "bttnBereken";
            this.bttnBereken.Size = new System.Drawing.Size(184, 23);
            this.bttnBereken.TabIndex = 26;
            this.bttnBereken.Text = "Bereken aantal Friese meren";
            this.bttnBereken.UseVisualStyleBackColor = true;
            this.bttnBereken.Click += new System.EventHandler(this.bttnBereken_Click);
            // 
            // lblaantalf
            // 
            this.lblaantalf.AutoSize = true;
            this.lblaantalf.Location = new System.Drawing.Point(493, 442);
            this.lblaantalf.Name = "lblaantalf";
            this.lblaantalf.Size = new System.Drawing.Size(106, 13);
            this.lblaantalf.TabIndex = 27;
            this.lblaantalf.Text = "Aantal Friese meren: ";
            // 
            // lblTotpd
            // 
            this.lblTotpd.AutoSize = true;
            this.lblTotpd.Location = new System.Drawing.Point(12, 388);
            this.lblTotpd.Name = "lblTotpd";
            this.lblTotpd.Size = new System.Drawing.Size(124, 13);
            this.lblTotpd.TabIndex = 28;
            this.lblTotpd.Text = "Totaal bedrag per dag: €";
            // 
            // lblSluis
            // 
            this.lblSluis.AutoSize = true;
            this.lblSluis.Location = new System.Drawing.Point(12, 411);
            this.lblSluis.Name = "lblSluis";
            this.lblSluis.Size = new System.Drawing.Size(64, 13);
            this.lblSluis.TabIndex = 29;
            this.lblSluis.Text = "Sluis geld: €";
            // 
            // lblTotb
            // 
            this.lblTotb.AutoSize = true;
            this.lblTotb.Location = new System.Drawing.Point(12, 433);
            this.lblTotb.Name = "lblTotb";
            this.lblTotb.Size = new System.Drawing.Size(85, 13);
            this.lblTotb.TabIndex = 30;
            this.lblTotb.Text = "Totaal bedrag: €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Totaal bedrag per dag: €";
            // 
            // MaakHC
            // 
            this.MaakHC.Location = new System.Drawing.Point(529, 491);
            this.MaakHC.Name = "MaakHC";
            this.MaakHC.Size = new System.Drawing.Size(159, 23);
            this.MaakHC.TabIndex = 0;
            this.MaakHC.Text = "Maak Huurcontract";
            this.MaakHC.UseVisualStyleBackColor = true;
            this.MaakHC.Click += new System.EventHandler(this.MaakHC_Click);
            // 
            // txtnaam
            // 
            this.txtnaam.Location = new System.Drawing.Point(330, 519);
            this.txtnaam.Name = "txtnaam";
            this.txtnaam.Size = new System.Drawing.Size(143, 20);
            this.txtnaam.TabIndex = 1;
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Location = new System.Drawing.Point(286, 522);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(38, 13);
            this.lblnaam.TabIndex = 31;
            this.lblnaam.Text = "Naam:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(330, 493);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(143, 20);
            this.txtemail.TabIndex = 32;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(287, 496);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 33;
            this.lblemail.Text = "Email:";
            // 
            // bttnOverzicht
            // 
            this.bttnOverzicht.Location = new System.Drawing.Point(529, 515);
            this.bttnOverzicht.Name = "bttnOverzicht";
            this.bttnOverzicht.Size = new System.Drawing.Size(159, 23);
            this.bttnOverzicht.TabIndex = 34;
            this.bttnOverzicht.Text = "Ga naar het Overzicht";
            this.bttnOverzicht.UseVisualStyleBackColor = true;
            this.bttnOverzicht.Click += new System.EventHandler(this.bttnOverzicht_Click);
            // 
            // bttninuitlog
            // 
            this.bttninuitlog.Location = new System.Drawing.Point(11, 512);
            this.bttninuitlog.Name = "bttninuitlog";
            this.bttninuitlog.Size = new System.Drawing.Size(103, 23);
            this.bttninuitlog.TabIndex = 35;
            this.bttninuitlog.Text = "Home";
            this.bttninuitlog.UseVisualStyleBackColor = true;
            this.bttninuitlog.Click += new System.EventHandler(this.bttninuitlog_Click);
            // 
            // Huur_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 549);
            this.Controls.Add(this.bttninuitlog);
            this.Controls.Add(this.bttnOverzicht);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblnaam);
            this.Controls.Add(this.MaakHC);
            this.Controls.Add(this.txtnaam);
            this.Controls.Add(this.lblTotb);
            this.Controls.Add(this.lblSluis);
            this.Controls.Add(this.lblTotpd);
            this.Controls.Add(this.lblaantalf);
            this.Controls.Add(this.bttnBereken);
            this.Controls.Add(this.varen);
            this.Controls.Add(this.GBPeriode);
            this.Controls.Add(this.lblkostenart);
            this.Controls.Add(this.lblkostenboot);
            this.Controls.Add(this.kostenart);
            this.Controls.Add(this.kostenboot);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.lblbudget);
            this.Controls.Add(this.lblArtR);
            this.Controls.Add(this.lblArtL);
            this.Controls.Add(this.ArtNL);
            this.Controls.Add(this.ArtNR);
            this.Controls.Add(this.ArtR);
            this.Controls.Add(this.ArtL);
            this.Controls.Add(this.BootNL);
            this.Controls.Add(this.BootNR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBotenL);
            this.Controls.Add(this.BotenR);
            this.Controls.Add(this.BotenL);
            this.Name = "Huur_menu";
            this.Text = "Huur_menu";
            ((System.ComponentModel.ISupportInitialize)(this.budget)).EndInit();
            this.GBPeriode.ResumeLayout(false);
            this.GBPeriode.PerformLayout();
            this.varen.ResumeLayout(false);
            this.varen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BotenL;
        private System.Windows.Forms.ListBox BotenR;
        private System.Windows.Forms.Label lblBotenL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BootNR;
        private System.Windows.Forms.Button BootNL;
        private System.Windows.Forms.ListBox ArtL;
        private System.Windows.Forms.ListBox ArtR;
        private System.Windows.Forms.Button ArtNR;
        private System.Windows.Forms.Button ArtNL;
        private System.Windows.Forms.Label lblArtL;
        private System.Windows.Forms.Label lblArtR;
        private System.Windows.Forms.Label lblbudget;
        private System.Windows.Forms.NumericUpDown budget;
        private System.Windows.Forms.Label kostenboot;
        private System.Windows.Forms.Label kostenart;
        private System.Windows.Forms.Label lblkostenboot;
        private System.Windows.Forms.Label lblkostenart;
        private System.Windows.Forms.DateTimePicker DateT;
        private System.Windows.Forms.DateTimePicker DateV;
        private System.Windows.Forms.GroupBox GBPeriode;
        private System.Windows.Forms.Label lbldagen;
        private System.Windows.Forms.Button bttnBdagen;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblvanaf;
        private System.Windows.Forms.CheckBox IJsselmeercheck;
        private System.Windows.Forms.CheckBox Noordzeecheck;
        private System.Windows.Forms.GroupBox varen;
        private System.Windows.Forms.Button bttnBereken;
        private System.Windows.Forms.Label lblaantalf;
        private System.Windows.Forms.Label lblTotpd;
        private System.Windows.Forms.Label lblSluis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotb;
        private System.Windows.Forms.Button MaakHC;
        private System.Windows.Forms.TextBox txtnaam;
        private System.Windows.Forms.Label lblnaam;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button bttnOverzicht;
        private System.Windows.Forms.Button bttninuitlog;
    }
}