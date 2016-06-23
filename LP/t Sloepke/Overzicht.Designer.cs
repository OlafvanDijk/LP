namespace t_Sloepke
{
    partial class Overzicht
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
            this.HuurContractenA = new System.Windows.Forms.ListBox();
            this.HuurContractenB = new System.Windows.Forms.ListBox();
            this.lblHL = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.bttnexp = new System.Windows.Forms.Button();
            this.bttntemp = new System.Windows.Forms.Button();
            this.gvlTmp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HuurContractenA
            // 
            this.HuurContractenA.FormattingEnabled = true;
            this.HuurContractenA.Location = new System.Drawing.Point(15, 25);
            this.HuurContractenA.Name = "HuurContractenA";
            this.HuurContractenA.Size = new System.Drawing.Size(446, 199);
            this.HuurContractenA.TabIndex = 0;
            this.HuurContractenA.Click += new System.EventHandler(this.HuurContractenA_Click);
            // 
            // HuurContractenB
            // 
            this.HuurContractenB.FormattingEnabled = true;
            this.HuurContractenB.Location = new System.Drawing.Point(15, 265);
            this.HuurContractenB.Name = "HuurContractenB";
            this.HuurContractenB.Size = new System.Drawing.Size(446, 199);
            this.HuurContractenB.TabIndex = 1;
            this.HuurContractenB.Click += new System.EventHandler(this.HuurContractenB_Click);
            // 
            // lblHL
            // 
            this.lblHL.AutoSize = true;
            this.lblHL.Location = new System.Drawing.Point(12, 9);
            this.lblHL.Name = "lblHL";
            this.lblHL.Size = new System.Drawing.Size(104, 13);
            this.lblHL.TabIndex = 2;
            this.lblHL.Text = "Alle Huurcontracten:";
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(12, 249);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(113, 13);
            this.lblHR.TabIndex = 3;
            this.lblHR.Text = "Al jou Huurcontracten:";
            // 
            // bttnexp
            // 
            this.bttnexp.Location = new System.Drawing.Point(488, 25);
            this.bttnexp.Name = "bttnexp";
            this.bttnexp.Size = new System.Drawing.Size(131, 26);
            this.bttnexp.TabIndex = 4;
            this.bttnexp.Text = "Huurcontract exporteren";
            this.bttnexp.UseVisualStyleBackColor = true;
            this.bttnexp.Click += new System.EventHandler(this.bttnexp_Click);
            // 
            // bttntemp
            // 
            this.bttntemp.Location = new System.Drawing.Point(488, 84);
            this.bttntemp.Name = "bttntemp";
            this.bttntemp.Size = new System.Drawing.Size(131, 23);
            this.bttntemp.TabIndex = 5;
            this.bttntemp.Text = "Gevoels Temperatuur";
            this.bttntemp.UseVisualStyleBackColor = true;
            this.bttntemp.Click += new System.EventHandler(this.bttntemp_Click);
            // 
            // gvlTmp
            // 
            this.gvlTmp.FormattingEnabled = true;
            this.gvlTmp.Location = new System.Drawing.Point(488, 265);
            this.gvlTmp.Name = "gvlTmp";
            this.gvlTmp.Size = new System.Drawing.Size(230, 173);
            this.gvlTmp.TabIndex = 6;
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 476);
            this.Controls.Add(this.gvlTmp);
            this.Controls.Add(this.bttntemp);
            this.Controls.Add(this.bttnexp);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.lblHL);
            this.Controls.Add(this.HuurContractenB);
            this.Controls.Add(this.HuurContractenA);
            this.Name = "Overzicht";
            this.Text = "Overzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HuurContractenA;
        private System.Windows.Forms.ListBox HuurContractenB;
        private System.Windows.Forms.Label lblHL;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Button bttnexp;
        private System.Windows.Forms.Button bttntemp;
        private System.Windows.Forms.ListBox gvlTmp;
    }
}