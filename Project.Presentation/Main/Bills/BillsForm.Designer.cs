namespace Project.Presentation.Main.Bills
{
    partial class BillsForm
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
            this.panelBase = new System.Windows.Forms.Panel();
            this.btnPerDay = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBase.BackColor = System.Drawing.SystemColors.Control;
            this.panelBase.Location = new System.Drawing.Point(12, 58);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(590, 491);
            this.panelBase.TabIndex = 6;
            // 
            // btnPerDay
            // 
            this.btnPerDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerDay.Image = global::Project.Presentation.Properties.Resources._24_historic;
            this.btnPerDay.Location = new System.Drawing.Point(244, 12);
            this.btnPerDay.Name = "btnPerDay";
            this.btnPerDay.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPerDay.Size = new System.Drawing.Size(110, 40);
            this.btnPerDay.TabIndex = 13;
            this.btnPerDay.Text = "Registros";
            this.btnPerDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerDay.UseVisualStyleBackColor = true;
            this.btnPerDay.Click += new System.EventHandler(this.btnHistoric_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsult.Image = global::Project.Presentation.Properties.Resources._24_search;
            this.btnConsult.Location = new System.Drawing.Point(128, 12);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnConsult.Size = new System.Drawing.Size(110, 40);
            this.btnConsult.TabIndex = 12;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnControl
            // 
            this.btnControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControl.Image = global::Project.Presentation.Properties.Resources._24_add_expenditure;
            this.btnControl.Location = new System.Drawing.Point(12, 12);
            this.btnControl.Name = "btnControl";
            this.btnControl.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnControl.Size = new System.Drawing.Size(110, 40);
            this.btnControl.TabIndex = 10;
            this.btnControl.Text = "Agregar";
            this.btnControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.btnPerDay);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.panelBase);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BillsForm";
            this.Text = "BillsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnPerDay;
    }
}