namespace RemiseGenerator
{
    partial class GeneratorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDATA = new System.Windows.Forms.ListBox();
            this.treeXML = new System.Windows.Forms.TreeView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAnnuller = new System.Windows.Forms.Button();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.BtnLoadXML = new System.Windows.Forms.Button();
            this.SelectXML = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDATA);
            this.groupBox1.Controls.Add(this.treeXML);
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 523);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // lstDATA
            // 
            this.lstDATA.FormattingEnabled = true;
            this.lstDATA.Location = new System.Drawing.Point(19, 268);
            this.lstDATA.Name = "lstDATA";
            this.lstDATA.Size = new System.Drawing.Size(555, 238);
            this.lstDATA.TabIndex = 1;
            // 
            // treeXML
            // 
            this.treeXML.Location = new System.Drawing.Point(19, 19);
            this.treeXML.Name = "treeXML";
            this.treeXML.Size = new System.Drawing.Size(555, 243);
            this.treeXML.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(825, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 43);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnQuitter);
            this.groupBox2.Controls.Add(this.SelectXML);
            this.groupBox2.Controls.Add(this.BtnAnnuller);
            this.groupBox2.Controls.Add(this.BtnEnregistrer);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.BtnLoadXML);
            this.groupBox2.Location = new System.Drawing.Point(638, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 519);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // BtnAnnuller
            // 
            this.BtnAnnuller.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAnnuller.Location = new System.Drawing.Point(10, 197);
            this.BtnAnnuller.Name = "BtnAnnuller";
            this.BtnAnnuller.Size = new System.Drawing.Size(153, 39);
            this.BtnAnnuller.TabIndex = 3;
            this.BtnAnnuller.Text = "Annuller";
            this.BtnAnnuller.UseVisualStyleBackColor = false;
            this.BtnAnnuller.Click += new System.EventHandler(this.BtnAnnuller_Click);
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnEnregistrer.Location = new System.Drawing.Point(10, 152);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(153, 39);
            this.BtnEnregistrer.TabIndex = 2;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = false;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerate.Location = new System.Drawing.Point(10, 107);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(153, 39);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generer";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // BtnLoadXML
            // 
            this.BtnLoadXML.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnLoadXML.Location = new System.Drawing.Point(10, 62);
            this.BtnLoadXML.Name = "BtnLoadXML";
            this.BtnLoadXML.Size = new System.Drawing.Size(153, 39);
            this.BtnLoadXML.TabIndex = 0;
            this.BtnLoadXML.Text = "Charger XML";
            this.BtnLoadXML.UseVisualStyleBackColor = false;
            this.BtnLoadXML.Click += new System.EventHandler(this.BtnLoadXML_Click);
            // 
            // SelectXML
            // 
            this.SelectXML.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SelectXML.Location = new System.Drawing.Point(10, 15);
            this.SelectXML.Name = "SelectXML";
            this.SelectXML.Size = new System.Drawing.Size(153, 39);
            this.SelectXML.TabIndex = 4;
            this.SelectXML.Text = "Select XML";
            this.SelectXML.UseVisualStyleBackColor = false;
            this.SelectXML.Click += new System.EventHandler(this.SelectXML_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnQuitter.Location = new System.Drawing.Point(10, 463);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(153, 39);
            this.BtnQuitter.TabIndex = 5;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = false;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(862, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneratorForm";
            this.Text = "GeneratorForm";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDATA;
        private System.Windows.Forms.TreeView treeXML;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAnnuller;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button BtnLoadXML;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button SelectXML;
        private System.Windows.Forms.Button BtnQuitter;
    }
}