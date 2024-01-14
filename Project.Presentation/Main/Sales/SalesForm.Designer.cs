namespace Project.Presentation.Main.Sales
{
    partial class SalesForm
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
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBase = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Image = global::Project.Presentation.Properties.Resources._24_add;
            this.btnNewOrder.Location = new System.Drawing.Point(12, 12);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnNewOrder.Size = new System.Drawing.Size(164, 40);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "Registrar pedido";
            this.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Project.Presentation.Properties.Resources._24_historic;
            this.button2.Location = new System.Drawing.Point(182, 12);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(152, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Historial del día";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelBase
            // 
            this.panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBase.BackColor = System.Drawing.SystemColors.Control;
            this.panelBase.Location = new System.Drawing.Point(12, 58);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(790, 656);
            this.panelBase.TabIndex = 7;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(814, 726);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNewOrder);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelBase;
    }
}