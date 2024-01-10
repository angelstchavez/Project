namespace Project.Presentation.Main.Customers
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::Project.Presentation.Properties.Resources._24_add;
            this.btnAdd.Location = new System.Drawing.Point(284, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Image = global::Project.Presentation.Properties.Resources._24_edit;
            this.btnEdit.Location = new System.Drawing.Point(365, 474);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 75);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::Project.Presentation.Properties.Resources._24_delete;
            this.button2.Location = new System.Drawing.Point(446, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::Project.Presentation.Properties.Resources._24_report;
            this.button1.Location = new System.Drawing.Point(527, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reporte";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelCount.Location = new System.Drawing.Point(8, 16);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(162, 19);
            this.labelCount.TabIndex = 14;
            this.labelCount.Text = "Clientes registrados";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(449, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 13;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(527, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 12;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(274, 14);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 26);
            this.txtUsername.TabIndex = 11;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.Column1,
            this.Column2});
            this.dataGridView.Location = new System.Drawing.Point(12, 48);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.Size = new System.Drawing.Size(590, 371);
            this.dataGridView.TabIndex = 10;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "Id";
            this.idCol.Name = "idCol";
            this.idCol.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Teléfono";
            this.Column2.Name = "Column2";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNextPage.Location = new System.Drawing.Point(512, 425);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(90, 30);
            this.btnNextPage.TabIndex = 15;
            this.btnNextPage.Text = "Siguiente";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousPage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousPage.Location = new System.Drawing.Point(12, 425);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(90, 30);
            this.btnPreviousPage.TabIndex = 16;
            this.btnPreviousPage.Text = "Anterior";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // labelPage
            // 
            this.labelPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPage.Location = new System.Drawing.Point(108, 425);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(398, 30);
            this.labelPage.TabIndex = 17;
            this.labelPage.Text = "Cargando paginado...";
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}