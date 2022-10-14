namespace Računanje_Determinante
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeterminanta = new System.Windows.Forms.Label();
            this.lblTipDeterminante = new System.Windows.Forms.Label();
            this.panelKontener = new System.Windows.Forms.Panel();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelKontener.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "2x2",
            "3x3",
            "4x4",
            "5x5",
            "6x6",
            "7x7",
            "8x8"});
            this.cbSize.Location = new System.Drawing.Point(126, 10);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 21);
            this.cbSize.TabIndex = 35;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 363);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Matrica [A]: ";
            // 
            // lblDeterminanta
            // 
            this.lblDeterminanta.AutoSize = true;
            this.lblDeterminanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeterminanta.Location = new System.Drawing.Point(616, 39);
            this.lblDeterminanta.Name = "lblDeterminanta";
            this.lblDeterminanta.Size = new System.Drawing.Size(84, 24);
            this.lblDeterminanta.TabIndex = 37;
            this.lblDeterminanta.Text = "det [A]: 1";
            // 
            // lblTipDeterminante
            // 
            this.lblTipDeterminante.AutoSize = true;
            this.lblTipDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTipDeterminante.Location = new System.Drawing.Point(616, 79);
            this.lblTipDeterminante.Name = "lblTipDeterminante";
            this.lblTipDeterminante.Size = new System.Drawing.Size(151, 48);
            this.lblTipDeterminante.TabIndex = 38;
            this.lblTipDeterminante.Text = "Determinanta je: \r\n- regularna";
            // 
            // panelKontener
            // 
            this.panelKontener.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelKontener.Controls.Add(this.panel1);
            this.panelKontener.Location = new System.Drawing.Point(16, 39);
            this.panelKontener.Name = "panelKontener";
            this.panelKontener.Size = new System.Drawing.Size(576, 473);
            this.panelKontener.TabIndex = 39;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunaj.Location = new System.Drawing.Point(598, 426);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(226, 52);
            this.btnIzracunaj.TabIndex = 40;
            this.btnIzracunaj.Text = "IZRAČUNAJ";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // linkWebsite
            // 
            this.linkWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkWebsite.AutoSize = true;
            this.linkWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkWebsite.Location = new System.Drawing.Point(727, 496);
            this.linkWebsite.Name = "linkWebsite";
            this.linkWebsite.Size = new System.Drawing.Size(97, 16);
            this.linkWebsite.TabIndex = 42;
            this.linkWebsite.TabStop = true;
            this.linkWebsite.Text = "http://kraljic.xyz";
            this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(702, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Autor: Marko Kraljić";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 524);
            this.Controls.Add(this.linkWebsite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.panelKontener);
            this.Controls.Add(this.lblTipDeterminante);
            this.Controls.Add(this.lblDeterminanta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Računanje Determinante Matrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelKontener.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeterminanta;
        private System.Windows.Forms.Label lblTipDeterminante;
        private System.Windows.Forms.Panel panelKontener;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.Label label2;
    }
}

