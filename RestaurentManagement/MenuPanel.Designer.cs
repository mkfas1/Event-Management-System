namespace RestaurentManagement
{
    partial class MenuPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuTableGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuAddButton = new System.Windows.Forms.Button();
            this.menuPanelSearchBox = new System.Windows.Forms.TextBox();
            this.menuDeleteButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.MenuPanelTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuTableGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTableGridView
            // 
            this.menuTableGridView.AllowUserToAddRows = false;
            this.menuTableGridView.AllowUserToDeleteRows = false;
            this.menuTableGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuTableGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.menuTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuTableGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuTableGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.menuTableGridView.Location = new System.Drawing.Point(3, 3);
            this.menuTableGridView.Name = "menuTableGridView";
            this.menuTableGridView.ReadOnly = true;
            this.menuTableGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.menuTableGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.menuTableGridView.Size = new System.Drawing.Size(1158, 515);
            this.menuTableGridView.TabIndex = 0;
            this.menuTableGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuTableGridView_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuTableGridView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.45501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.54499F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1164, 589);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Controls.Add(this.menuAddButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.menuPanelSearchBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ReloadButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.menuDeleteButton, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 524);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1158, 62);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // menuAddButton
            // 
            this.menuAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.menuAddButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAddButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.menuAddButton.Location = new System.Drawing.Point(878, 14);
            this.menuAddButton.Name = "menuAddButton";
            this.menuAddButton.Size = new System.Drawing.Size(75, 34);
            this.menuAddButton.TabIndex = 5;
            this.menuAddButton.Text = "Add";
            this.menuAddButton.UseVisualStyleBackColor = false;
            this.menuAddButton.Click += new System.EventHandler(this.menuAddButton_Click_1);
            // 
            // menuPanelSearchBox
            // 
            this.menuPanelSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuPanelSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPanelSearchBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuPanelSearchBox.Location = new System.Drawing.Point(3, 15);
            this.menuPanelSearchBox.Multiline = true;
            this.menuPanelSearchBox.Name = "menuPanelSearchBox";
            this.menuPanelSearchBox.Size = new System.Drawing.Size(100, 32);
            this.menuPanelSearchBox.TabIndex = 0;
            this.menuPanelSearchBox.Text = "Search...";
            this.menuPanelSearchBox.TextChanged += new System.EventHandler(this.menuPanelSearchBox_TextChanged);
            this.menuPanelSearchBox.Enter += new System.EventHandler(this.menuPanelSearchBox_Enter);
            this.menuPanelSearchBox.Leave += new System.EventHandler(this.menuPanelSearchBox_Leave);
            // 
            // menuDeleteButton
            // 
            this.menuDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.menuDeleteButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDeleteButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.menuDeleteButton.Location = new System.Drawing.Point(1080, 14);
            this.menuDeleteButton.Name = "menuDeleteButton";
            this.menuDeleteButton.Size = new System.Drawing.Size(75, 34);
            this.menuDeleteButton.TabIndex = 3;
            this.menuDeleteButton.Text = "Delete";
            this.menuDeleteButton.UseVisualStyleBackColor = false;
            this.menuDeleteButton.Click += new System.EventHandler(this.menuDeleteButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReloadButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReloadButton.Location = new System.Drawing.Point(971, 14);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(91, 34);
            this.ReloadButton.TabIndex = 4;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(1170, 592);
            this.Load += new System.EventHandler(this.MenuPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuTableGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView menuTableGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox menuPanelSearchBox;
        private System.Windows.Forms.Button menuDeleteButton;
        private System.Windows.Forms.Timer MenuPanelTimer;
        private System.Windows.Forms.Button menuAddButton;
        private System.Windows.Forms.Button ReloadButton;
    }
}
