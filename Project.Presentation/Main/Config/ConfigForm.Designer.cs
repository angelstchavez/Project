namespace Project.Presentation.Main.Config
{
    partial class ConfigForm
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
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.panelBase = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLicence = new System.Windows.Forms.Button();
            this.btnPrints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompany
            // 
            this.btnCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompany.Image = global::Project.Presentation.Properties.Resources._24_company;
            this.btnCompany.Location = new System.Drawing.Point(12, 12);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCompany.Size = new System.Drawing.Size(107, 40);
            this.btnCompany.TabIndex = 0;
            this.btnCompany.Text = "Empresa";
            this.btnCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicket.Image = global::Project.Presentation.Properties.Resources._24_ticket;
            this.btnTicket.Location = new System.Drawing.Point(253, 12);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnTicket.Size = new System.Drawing.Size(85, 40);
            this.btnTicket.TabIndex = 2;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // panelBase
            // 
            this.panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBase.BackColor = System.Drawing.SystemColors.Control;
            this.panelBase.Location = new System.Drawing.Point(12, 58);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(990, 656);
            this.panelBase.TabIndex = 5;
            // 
            // btnBackup
            // 
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Image = global::Project.Presentation.Properties.Resources._24_backup;
            this.btnBackup.Location = new System.Drawing.Point(344, 12);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnBackup.Size = new System.Drawing.Size(100, 40);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnLicence
            // 
            this.btnLicence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLicence.Image = global::Project.Presentation.Properties.Resources._24_licence;
            this.btnLicence.Location = new System.Drawing.Point(450, 12);
            this.btnLicence.Name = "btnLicence";
            this.btnLicence.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnLicence.Size = new System.Drawing.Size(105, 40);
            this.btnLicence.TabIndex = 3;
            this.btnLicence.Text = "Licencia";
            this.btnLicence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLicence.UseVisualStyleBackColor = true;
            this.btnLicence.Click += new System.EventHandler(this.btnLicence_Click);
            // 
            // btnPrints
            // 
            this.btnPrints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrints.Image = global::Project.Presentation.Properties.Resources._24_print;
            this.btnPrints.Location = new System.Drawing.Point(125, 12);
            this.btnPrints.Name = "btnPrints";
            this.btnPrints.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPrints.Size = new System.Drawing.Size(122, 40);
            this.btnPrints.TabIndex = 1;
            this.btnPrints.Text = "Impresoras";
            this.btnPrints.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrints.UseVisualStyleBackColor = true;
            this.btnPrints.Click += new System.EventHandler(this.btnPrints_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1014, 726);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnLicence);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnPrints);
            this.Controls.Add(this.btnCompany);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnPrints;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnLicence;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel panelBase;
    }
}