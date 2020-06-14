namespace RestaurentManagement
{
    partial class EmployeePanel
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.employeeAddButton = new System.Windows.Forms.Button();
            this.employeeSearchBox = new System.Windows.Forms.TextBox();
            this.employeeDeleteButton = new System.Windows.Forms.Button();
            this.employeeTableGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.employeeTableGridView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.45501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.54499F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 592);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.Controls.Add(this.ReloadButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.employeeAddButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.employeeSearchBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.employeeDeleteButton, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 526);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1161, 62);
            this.tableLayoutPanel2.TabIndex = 1;
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
            this.ReloadButton.TabIndex = 12;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // employeeAddButton
            // 
            this.employeeAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.employeeAddButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.employeeAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeeAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeAddButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.employeeAddButton.Location = new System.Drawing.Point(879, 14);
            this.employeeAddButton.Name = "employeeAddButton";
            this.employeeAddButton.Size = new System.Drawing.Size(75, 34);
            this.employeeAddButton.TabIndex = 10;
            this.employeeAddButton.Text = "Add";
            this.employeeAddButton.UseVisualStyleBackColor = false;
            this.employeeAddButton.Click += new System.EventHandler(this.employeeAddButton_Click);
            // 
            // employeeSearchBox
            // 
            this.employeeSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.employeeSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSearchBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeSearchBox.Location = new System.Drawing.Point(3, 15);
            this.employeeSearchBox.Multiline = true;
            this.employeeSearchBox.Name = "employeeSearchBox";
            this.employeeSearchBox.Size = new System.Drawing.Size(100, 32);
            this.employeeSearchBox.TabIndex = 0;
            this.employeeSearchBox.Text = "Search...";
            this.employeeSearchBox.TextChanged += new System.EventHandler(this.employeeSearchBox_TextChanged);
            this.employeeSearchBox.Enter += new System.EventHandler(this.employeeSearchBox_Enter);
            this.employeeSearchBox.Leave += new System.EventHandler(this.employeeSearchBox_Leave);
            // 
            // employeeDeleteButton
            // 
            this.employeeDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.employeeDeleteButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.employeeDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeeDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDeleteButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.employeeDeleteButton.Location = new System.Drawing.Point(1083, 14);
            this.employeeDeleteButton.Name = "employeeDeleteButton";
            this.employeeDeleteButton.Size = new System.Drawing.Size(75, 34);
            this.employeeDeleteButton.TabIndex = 11;
            this.employeeDeleteButton.Text = "Delete";
            this.employeeDeleteButton.UseVisualStyleBackColor = false;
            this.employeeDeleteButton.Click += new System.EventHandler(this.employeeDeleteButton_Click_1);
            // 
            // employeeTableGridView
            // 
            this.employeeTableGridView.AllowUserToAddRows = false;
            this.employeeTableGridView.AllowUserToDeleteRows = false;
            this.employeeTableGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeTableGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTableGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeTableGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.employeeTableGridView.Location = new System.Drawing.Point(3, 3);
            this.employeeTableGridView.Name = "employeeTableGridView";
            this.employeeTableGridView.ReadOnly = true;
            this.employeeTableGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeTableGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeTableGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employeeTableGridView.Size = new System.Drawing.Size(1161, 517);
            this.employeeTableGridView.TabIndex = 2;
            this.employeeTableGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeTableGridView_CellDoubleClick);
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeePanel";
            this.Size = new System.Drawing.Size(1170, 592);
            this.Load += new System.EventHandler(this.EmployeePanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox employeeSearchBox;
        private System.Windows.Forms.DataGridView employeeTableGridView;
        private System.Windows.Forms.Button employeeAddButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button employeeDeleteButton;
    }
}
