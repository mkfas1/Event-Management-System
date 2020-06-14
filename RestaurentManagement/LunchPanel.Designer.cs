namespace RestaurentManagement
{
    partial class LunchPanel
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
            this.LunchOrderButton = new System.Windows.Forms.Button();
            this.lunchGridView = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RM4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lunchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose From Lunch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LunchOrderButton
            // 
            this.LunchOrderButton.BackColor = System.Drawing.Color.Tomato;
            this.LunchOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LunchOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LunchOrderButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LunchOrderButton.Location = new System.Drawing.Point(1030, 25);
            this.LunchOrderButton.Name = "LunchOrderButton";
            this.LunchOrderButton.Size = new System.Drawing.Size(99, 35);
            this.LunchOrderButton.TabIndex = 6;
            this.LunchOrderButton.Text = "Order";
            this.LunchOrderButton.UseVisualStyleBackColor = false;
            this.LunchOrderButton.Click += new System.EventHandler(this.LunchOrderButton_Click);
            // 
            // lunchGridView
            // 
            this.lunchGridView.AllowUserToAddRows = false;
            this.lunchGridView.AllowUserToDeleteRows = false;
            this.lunchGridView.AllowUserToResizeRows = false;
            this.lunchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lunchGridView.BackgroundColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lunchGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lunchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lunchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.ID,
            this.Name,
            this.Price,
            this.RM1,
            this.RM2,
            this.RM3,
            this.RM4});
            this.lunchGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lunchGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.lunchGridView.Location = new System.Drawing.Point(32, 85);
            this.lunchGridView.Name = "lunchGridView";
            this.lunchGridView.RowHeadersVisible = false;
            this.lunchGridView.Size = new System.Drawing.Size(1097, 462);
            this.lunchGridView.TabIndex = 7;
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
            // LunchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.Controls.Add(this.lunchGridView);
            this.Controls.Add(this.LunchOrderButton);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(1160, 580);
            this.Load += new System.EventHandler(this.LunchPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lunchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LunchOrderButton;
        private System.Windows.Forms.DataGridView lunchGridView;
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
