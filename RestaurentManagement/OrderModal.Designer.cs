namespace RestaurentManagement
{
    partial class OrderModal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModal));
            this.orderChartGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rm3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rm4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderChartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderChartGridView
            // 
            this.orderChartGridView.AllowUserToAddRows = false;
            this.orderChartGridView.AllowUserToDeleteRows = false;
            this.orderChartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderChartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderChartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderChartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Price,
            this.Rm1,
            this.Rm2,
            this.Rm3,
            this.Rm4,
            this.Quantity});
            this.orderChartGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderChartGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderChartGridView.Location = new System.Drawing.Point(21, 55);
            this.orderChartGridView.Name = "orderChartGridView";
            this.orderChartGridView.RowHeadersVisible = false;
            this.orderChartGridView.Size = new System.Drawing.Size(754, 315);
            this.orderChartGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FillWeight = 15F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.FillWeight = 30F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 20F;
            this.Price.HeaderText = "Unit Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Rm1
            // 
            this.Rm1.FillWeight = 20F;
            this.Rm1.HeaderText = "Rm1";
            this.Rm1.Name = "Rm1";
            // 
            // Rm2
            // 
            this.Rm2.FillWeight = 20F;
            this.Rm2.HeaderText = "Rm2";
            this.Rm2.Name = "Rm2";
            // 
            // Rm3
            // 
            this.Rm3.FillWeight = 20F;
            this.Rm3.HeaderText = "Rm3";
            this.Rm3.Name = "Rm3";
            // 
            // Rm4
            // 
            this.Rm4.FillWeight = 20F;
            this.Rm4.HeaderText = "Rm4";
            this.Rm4.Name = "Rm4";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 30F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Chart";
            // 
            // ProceedButton
            // 
            this.ProceedButton.BackColor = System.Drawing.Color.SlateGray;
            this.ProceedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProceedButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProceedButton.Location = new System.Drawing.Point(686, 394);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(89, 34);
            this.ProceedButton.TabIndex = 2;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = false;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton.Location = new System.Drawing.Point(21, 394);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 34);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderChartGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderModal";
            this.Load += new System.EventHandler(this.OrderModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderChartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderChartGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rm4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}