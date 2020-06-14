namespace RestaurentManagement
{
    partial class InventoryPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rawTableGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inventoryAddButton = new System.Windows.Forms.Button();
            this.inventorySearchBox = new System.Windows.Forms.TextBox();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.inventoryDeleteButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawTableGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rawTableGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.45501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.54499F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 592);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rawTableGridView
            // 
            this.rawTableGridView.AllowUserToAddRows = false;
            this.rawTableGridView.AllowUserToDeleteRows = false;
            this.rawTableGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rawTableGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rawTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawTableGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rawTableGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.rawTableGridView.Location = new System.Drawing.Point(3, 3);
            this.rawTableGridView.Name = "rawTableGridView";
            this.rawTableGridView.ReadOnly = true;
            this.rawTableGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rawTableGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rawTableGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rawTableGridView.Size = new System.Drawing.Size(1161, 517);
            this.rawTableGridView.TabIndex = 0;
            this.rawTableGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rawTableGridView_CellContentClick);
            this.rawTableGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rawTableGridView_CellDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.Controls.Add(this.inventoryAddButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inventorySearchBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ReloadButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.inventoryDeleteButton, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 526);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1161, 62);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // inventoryAddButton
            // 
            this.inventoryAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inventoryAddButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.inventoryAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inventoryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAddButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inventoryAddButton.Location = new System.Drawing.Point(878, 14);
            this.inventoryAddButton.Name = "inventoryAddButton";
            this.inventoryAddButton.Size = new System.Drawing.Size(75, 34);
            this.inventoryAddButton.TabIndex = 7;
            this.inventoryAddButton.Text = "Add";
            this.inventoryAddButton.UseVisualStyleBackColor = false;
            this.inventoryAddButton.Click += new System.EventHandler(this.inventoryAddButton_Click_1);
            // 
            // inventorySearchBox
            // 
            this.inventorySearchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inventorySearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorySearchBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.inventorySearchBox.Location = new System.Drawing.Point(3, 15);
            this.inventorySearchBox.Multiline = true;
            this.inventorySearchBox.Name = "inventorySearchBox";
            this.inventorySearchBox.Size = new System.Drawing.Size(100, 32);
            this.inventorySearchBox.TabIndex = 0;
            this.inventorySearchBox.Text = "Search...";
            this.inventorySearchBox.TextChanged += new System.EventHandler(this.inventorySearchBox_TextChanged);
            this.inventorySearchBox.Enter += new System.EventHandler(this.inventorySearchBox_Enter);
            this.inventorySearchBox.Leave += new System.EventHandler(this.inventorySearchBox_Leave);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReloadButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReloadButton.Location = new System.Drawing.Point(972, 14);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(91, 34);
            this.ReloadButton.TabIndex = 6;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // inventoryDeleteButton
            // 
            this.inventoryDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inventoryDeleteButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.inventoryDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inventoryDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDeleteButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inventoryDeleteButton.Location = new System.Drawing.Point(1083, 14);
            this.inventoryDeleteButton.Name = "inventoryDeleteButton";
            this.inventoryDeleteButton.Size = new System.Drawing.Size(75, 34);
            this.inventoryDeleteButton.TabIndex = 3;
            this.inventoryDeleteButton.Text = "Delete";
            this.inventoryDeleteButton.UseVisualStyleBackColor = false;
            this.inventoryDeleteButton.Click += new System.EventHandler(this.inventoryDeleteButton_Click);
            // 
            // InventoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InventoryPanel";
            this.Size = new System.Drawing.Size(1170, 592);
            this.Load += new System.EventHandler(this.InventoryPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rawTableGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView rawTableGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox inventorySearchBox;
        private System.Windows.Forms.Button inventoryDeleteButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button inventoryAddButton;
        private System.Windows.Forms.Button ReloadButton;
    }
}
