namespace RestaurentManagement
{
    partial class BreakfastPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.breakfastGridView = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakfastOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose From Breakfast";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // breakfastGridView
            // 
            this.breakfastGridView.AllowUserToAddRows = false;
            this.breakfastGridView.AllowUserToDeleteRows = false;
            this.breakfastGridView.AllowUserToResizeRows = false;
            this.breakfastGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.breakfastGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.breakfastGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.breakfastGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breakfastGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.ID,
            this.Name,
            this.Price,
            this.RM1,
            this.RM2,
            this.RM3,
            this.RM4});
            this.breakfastGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.breakfastGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.breakfastGridView.Location = new System.Drawing.Point(32, 85);
            this.breakfastGridView.Name = "breakfastGridView";
            this.breakfastGridView.RowHeadersVisible = false;
            this.breakfastGridView.Size = new System.Drawing.Size(1097, 462);
            this.breakfastGridView.TabIndex = 9;
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
            // BreakfastOrderButton
            // 
            this.BreakfastOrderButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.BreakfastOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BreakfastOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BreakfastOrderButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakfastOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BreakfastOrderButton.Location = new System.Drawing.Point(1030, 25);
            this.BreakfastOrderButton.Name = "BreakfastOrderButton";
            this.BreakfastOrderButton.Size = new System.Drawing.Size(99, 35);
            this.BreakfastOrderButton.TabIndex = 8;
            this.BreakfastOrderButton.Text = "Order";
            this.BreakfastOrderButton.UseVisualStyleBackColor = false;
            this.BreakfastOrderButton.Click += new System.EventHandler(this.BreakfastOrderButton_Click);
            // 
            // BreakfastPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.breakfastGridView);
            this.Controls.Add(this.BreakfastOrderButton);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(1160, 580);
            this.Load += new System.EventHandler(this.BreakfastPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakfastGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView breakfastGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM4;
        private System.Windows.Forms.Button BreakfastOrderButton;
    }
}
