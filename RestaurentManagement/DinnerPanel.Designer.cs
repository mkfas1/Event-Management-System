namespace RestaurentManagement
{
    partial class DinnerPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dinnerGridView = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DinnerOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dinnerGridView
            // 
            this.dinnerGridView.AllowUserToAddRows = false;
            this.dinnerGridView.AllowUserToDeleteRows = false;
            this.dinnerGridView.AllowUserToResizeRows = false;
            this.dinnerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dinnerGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dinnerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dinnerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dinnerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.ID,
            this.Name,
            this.Price,
            this.RM1,
            this.RM2,
            this.RM3,
            this.RM4});
            this.dinnerGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dinnerGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dinnerGridView.Location = new System.Drawing.Point(32, 85);
            this.dinnerGridView.Name = "dinnerGridView";
            this.dinnerGridView.RowHeadersVisible = false;
            this.dinnerGridView.Size = new System.Drawing.Size(1097, 462);
            this.dinnerGridView.TabIndex = 4;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Select.FillWeight = 15F;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 10;
            this.Select.Name = "Select";
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
            this.Name.FillWeight = 37.70849F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 37.70849F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // RM1
            // 
            this.RM1.FillWeight = 20F;
            this.RM1.HeaderText = "RM1";
            this.RM1.Name = "RM1";
            this.RM1.ReadOnly = true;
            // 
            // RM2
            // 
            this.RM2.FillWeight = 20F;
            this.RM2.HeaderText = "RM2";
            this.RM2.Name = "RM2";
            this.RM2.ReadOnly = true;
            // 
            // RM3
            // 
            this.RM3.FillWeight = 20F;
            this.RM3.HeaderText = "RM3";
            this.RM3.Name = "RM3";
            this.RM3.ReadOnly = true;
            // 
            // RM4
            // 
            this.RM4.FillWeight = 20F;
            this.RM4.HeaderText = "RM4";
            this.RM4.Name = "RM4";
            this.RM4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose From Dinner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DinnerOrderButton
            // 
            this.DinnerOrderButton.BackColor = System.Drawing.Color.DimGray;
            this.DinnerOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DinnerOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DinnerOrderButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinnerOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DinnerOrderButton.Location = new System.Drawing.Point(1030, 25);
            this.DinnerOrderButton.Name = "DinnerOrderButton";
            this.DinnerOrderButton.Size = new System.Drawing.Size(99, 35);
            this.DinnerOrderButton.TabIndex = 5;
            this.DinnerOrderButton.Text = "Order";
            this.DinnerOrderButton.UseVisualStyleBackColor = false;
            this.DinnerOrderButton.Click += new System.EventHandler(this.DinnerOrderButton_Click);
            // 
            // DinnerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.DinnerOrderButton);
            this.Controls.Add(this.dinnerGridView);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Size = new System.Drawing.Size(1160, 580);
            this.Load += new System.EventHandler(this.DinnerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dinnerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dinnerGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DinnerOrderButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM4;
    }
}
