namespace RestaurentManagement
{
    partial class MenuModal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuModal));
            this.DoneButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuModalComboBoxRaw1 = new System.Windows.Forms.ComboBox();
            this.rawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurentDataSet = new RestaurentManagement.restaurentDataSet();
            this.menuModalComboBoxRaw2 = new System.Windows.Forms.ComboBox();
            this.rawBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurentDataSet1 = new RestaurentManagement.restaurentDataSet1();
            this.menuModalComboBoxRaw3 = new System.Windows.Forms.ComboBox();
            this.rawBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurentDataSet2 = new RestaurentManagement.restaurentDataSet2();
            this.menuModalComboBoxRaw4 = new System.Windows.Forms.ComboBox();
            this.rawBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurentDataSet3 = new RestaurentManagement.restaurentDataSet3();
            this.rawTableAdapter = new RestaurentManagement.restaurentDataSetTableAdapters.RawTableAdapter();
            this.rawTableAdapter1 = new RestaurentManagement.restaurentDataSet1TableAdapters.RawTableAdapter();
            this.rawTableAdapter2 = new RestaurentManagement.restaurentDataSet2TableAdapters.RawTableAdapter();
            this.rawTableAdapter3 = new RestaurentManagement.restaurentDataSet3TableAdapters.RawTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.timeSelectComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurentDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.DoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(211, 489);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(82, 33);
            this.DoneButton.TabIndex = 26;
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(92, 489);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 33);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceTextBox.Location = new System.Drawing.Point(126, 127);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(213, 28);
            this.priceTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(55, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Price";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameTextBox.Location = new System.Drawing.Point(126, 64);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 28);
            this.nameTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(49, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Raw 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(49, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Raw 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(50, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Raw 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(46, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Raw 4";
            // 
            // menuModalComboBoxRaw1
            // 
            this.menuModalComboBoxRaw1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuModalComboBoxRaw1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuModalComboBoxRaw1.DataSource = this.rawBindingSource;
            this.menuModalComboBoxRaw1.DisplayMember = "Name";
            this.menuModalComboBoxRaw1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuModalComboBoxRaw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuModalComboBoxRaw1.ForeColor = System.Drawing.SystemColors.Window;
            this.menuModalComboBoxRaw1.FormattingEnabled = true;
            this.menuModalComboBoxRaw1.Location = new System.Drawing.Point(126, 192);
            this.menuModalComboBoxRaw1.Name = "menuModalComboBoxRaw1";
            this.menuModalComboBoxRaw1.Size = new System.Drawing.Size(213, 28);
            this.menuModalComboBoxRaw1.TabIndex = 31;
            this.menuModalComboBoxRaw1.ValueMember = "Name";
            // 
            // rawBindingSource
            // 
            this.rawBindingSource.DataMember = "Raw";
            this.rawBindingSource.DataSource = this.restaurentDataSet;
            // 
            // restaurentDataSet
            // 
            this.restaurentDataSet.DataSetName = "restaurentDataSet";
            this.restaurentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuModalComboBoxRaw2
            // 
            this.menuModalComboBoxRaw2.BackColor = System.Drawing.Color.CadetBlue;
            this.menuModalComboBoxRaw2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuModalComboBoxRaw2.DataSource = this.rawBindingSource1;
            this.menuModalComboBoxRaw2.DisplayMember = "Name";
            this.menuModalComboBoxRaw2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuModalComboBoxRaw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuModalComboBoxRaw2.ForeColor = System.Drawing.SystemColors.Window;
            this.menuModalComboBoxRaw2.FormattingEnabled = true;
            this.menuModalComboBoxRaw2.Location = new System.Drawing.Point(126, 242);
            this.menuModalComboBoxRaw2.Name = "menuModalComboBoxRaw2";
            this.menuModalComboBoxRaw2.Size = new System.Drawing.Size(213, 28);
            this.menuModalComboBoxRaw2.TabIndex = 32;
            this.menuModalComboBoxRaw2.ValueMember = "Name";
            // 
            // rawBindingSource1
            // 
            this.rawBindingSource1.DataMember = "Raw";
            this.rawBindingSource1.DataSource = this.restaurentDataSet1;
            // 
            // restaurentDataSet1
            // 
            this.restaurentDataSet1.DataSetName = "restaurentDataSet1";
            this.restaurentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuModalComboBoxRaw3
            // 
            this.menuModalComboBoxRaw3.BackColor = System.Drawing.Color.CadetBlue;
            this.menuModalComboBoxRaw3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuModalComboBoxRaw3.DataSource = this.rawBindingSource2;
            this.menuModalComboBoxRaw3.DisplayMember = "Name";
            this.menuModalComboBoxRaw3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuModalComboBoxRaw3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuModalComboBoxRaw3.ForeColor = System.Drawing.SystemColors.Window;
            this.menuModalComboBoxRaw3.FormattingEnabled = true;
            this.menuModalComboBoxRaw3.Location = new System.Drawing.Point(126, 296);
            this.menuModalComboBoxRaw3.Name = "menuModalComboBoxRaw3";
            this.menuModalComboBoxRaw3.Size = new System.Drawing.Size(213, 28);
            this.menuModalComboBoxRaw3.TabIndex = 33;
            this.menuModalComboBoxRaw3.ValueMember = "Name";
            // 
            // rawBindingSource2
            // 
            this.rawBindingSource2.DataMember = "Raw";
            this.rawBindingSource2.DataSource = this.restaurentDataSet2;
            // 
            // restaurentDataSet2
            // 
            this.restaurentDataSet2.DataSetName = "restaurentDataSet2";
            this.restaurentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuModalComboBoxRaw4
            // 
            this.menuModalComboBoxRaw4.BackColor = System.Drawing.Color.CadetBlue;
            this.menuModalComboBoxRaw4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuModalComboBoxRaw4.DataSource = this.rawBindingSource3;
            this.menuModalComboBoxRaw4.DisplayMember = "Name";
            this.menuModalComboBoxRaw4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuModalComboBoxRaw4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuModalComboBoxRaw4.ForeColor = System.Drawing.SystemColors.Window;
            this.menuModalComboBoxRaw4.FormattingEnabled = true;
            this.menuModalComboBoxRaw4.Location = new System.Drawing.Point(126, 351);
            this.menuModalComboBoxRaw4.Name = "menuModalComboBoxRaw4";
            this.menuModalComboBoxRaw4.Size = new System.Drawing.Size(213, 28);
            this.menuModalComboBoxRaw4.TabIndex = 34;
            this.menuModalComboBoxRaw4.ValueMember = "Name";
            // 
            // rawBindingSource3
            // 
            this.rawBindingSource3.DataMember = "Raw";
            this.rawBindingSource3.DataSource = this.restaurentDataSet3;
            // 
            // restaurentDataSet3
            // 
            this.restaurentDataSet3.DataSetName = "restaurentDataSet3";
            this.restaurentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawTableAdapter
            // 
            this.rawTableAdapter.ClearBeforeFill = true;
            // 
            // rawTableAdapter1
            // 
            this.rawTableAdapter1.ClearBeforeFill = true;
            // 
            // rawTableAdapter2
            // 
            this.rawTableAdapter2.ClearBeforeFill = true;
            // 
            // rawTableAdapter3
            // 
            this.rawTableAdapter3.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(55, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Time";
            // 
            // timeSelectComboBox
            // 
            this.timeSelectComboBox.BackColor = System.Drawing.Color.CadetBlue;
            this.timeSelectComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeSelectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeSelectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSelectComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.timeSelectComboBox.FormattingEnabled = true;
            this.timeSelectComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.timeSelectComboBox.Location = new System.Drawing.Point(126, 406);
            this.timeSelectComboBox.Name = "timeSelectComboBox";
            this.timeSelectComboBox.Size = new System.Drawing.Size(213, 28);
            this.timeSelectComboBox.TabIndex = 36;
            // 
            // MenuModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(380, 595);
            this.Controls.Add(this.timeSelectComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuModalComboBoxRaw4);
            this.Controls.Add(this.menuModalComboBoxRaw3);
            this.Controls.Add(this.menuModalComboBoxRaw2);
            this.Controls.Add(this.menuModalComboBoxRaw1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuModal";
            this.Load += new System.EventHandler(this.MenuModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurentDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private restaurentDataSet restaurentDataSet;
        private System.Windows.Forms.BindingSource rawBindingSource;
        private restaurentDataSetTableAdapters.RawTableAdapter rawTableAdapter;
        private restaurentDataSet1 restaurentDataSet1;
        private System.Windows.Forms.BindingSource rawBindingSource1;
        private restaurentDataSet1TableAdapters.RawTableAdapter rawTableAdapter1;
        private restaurentDataSet2 restaurentDataSet2;
        private System.Windows.Forms.BindingSource rawBindingSource2;
        private restaurentDataSet2TableAdapters.RawTableAdapter rawTableAdapter2;
        private restaurentDataSet3 restaurentDataSet3;
        private System.Windows.Forms.BindingSource rawBindingSource3;
        private restaurentDataSet3TableAdapters.RawTableAdapter rawTableAdapter3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.ComboBox menuModalComboBoxRaw1;
        public System.Windows.Forms.ComboBox menuModalComboBoxRaw2;
        public System.Windows.Forms.ComboBox menuModalComboBoxRaw3;
        public System.Windows.Forms.ComboBox menuModalComboBoxRaw4;
        public System.Windows.Forms.ComboBox timeSelectComboBox;
    }
}