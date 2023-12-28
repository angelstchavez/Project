namespace Project.Presentation.Main.Bills
{
    partial class BillsControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsControlForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 30);
            this.panel1.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Firebrick;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(257, 30);
            this.txtTitle.TabIndex = 11;
            this.txtTitle.Text = "Registrar gasto";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Alimentos",
            "Aseo",
            "Arriendo",
            "Bebidas",
            "Empaques",
            "Equipamiento de Cocina",
            "Nomina",
            "Papelería",
            "Publicidad Física",
            "Publicidad Marketing",
            "Servicios Públicos",
            "Transporte",
            "Otro"});
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 186);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(231, 26);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 125);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(231, 26);
            this.txtDescription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor:";
            // 
            // btnAction
            // 
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(12, 284);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(231, 47);
            this.btnAction.TabIndex = 12;
            this.btnAction.Text = "Registrar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha:";
            // 
            // pickDate
            // 
            this.pickDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDate.Location = new System.Drawing.Point(12, 63);
            this.pickDate.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(231, 26);
            this.pickDate.TabIndex = 14;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Location = new System.Drawing.Point(12, 244);
            this.numericUpDownValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(231, 26);
            this.numericUpDownValue.TabIndex = 15;
            // 
            // BillsControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 341);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(273, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(273, 380);
            this.Name = "BillsControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BillsControlForm_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker pickDate;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
    }
}