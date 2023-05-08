namespace SuperMarketForm
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.superMarketDataSet = new SuperMarketForm.SuperMarketDataSet();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new SuperMarketForm.SuperMarketDataSetTableAdapters.CUSTOMERTableAdapter();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSCID2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSCID3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIGADMINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASESNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTPURCHASDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.button_info = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.textBoxaddress);
            this.panel1.Controls.Add(this.textBoxid);
            this.panel1.Controls.Add(this.textBox_lastname);
            this.panel1.Controls.Add(this.textBox_firstname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(196, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 516);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(151, 95);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(100, 24);
            this.textBox_firstname.TabIndex = 4;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(151, 145);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(100, 24);
            this.textBox_lastname.TabIndex = 5;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(151, 189);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 24);
            this.textBoxid.TabIndex = 6;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(151, 229);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(100, 24);
            this.textBoxaddress.TabIndex = 7;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(101, 288);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 48);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add\r\n";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(201, 288);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 48);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(151, 342);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 48);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fNAMEDataGridViewTextBoxColumn,
            this.lNAMEDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.cUSCIDDataGridViewTextBoxColumn,
            this.cUSCID2DataGridViewTextBoxColumn,
            this.cUSCID3DataGridViewTextBoxColumn,
            this.aDMINIDDataGridViewTextBoxColumn,
            this.sIGADMINIDDataGridViewTextBoxColumn,
            this.cADDRESDataGridViewTextBoxColumn,
            this.pURCHASESDataGridViewTextBoxColumn,
            this.pURCHASESNUMDataGridViewTextBoxColumn,
            this.lASTPURCHASDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(286, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(480, 408);
            this.dataGridView1.TabIndex = 11;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(691, 66);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 12;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.superMarketDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "F_NAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "F_NAME";
            this.fNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            this.fNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNAMEDataGridViewTextBoxColumn
            // 
            this.lNAMEDataGridViewTextBoxColumn.DataPropertyName = "L_NAME";
            this.lNAMEDataGridViewTextBoxColumn.HeaderText = "L_NAME";
            this.lNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNAMEDataGridViewTextBoxColumn.Name = "lNAMEDataGridViewTextBoxColumn";
            this.lNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSCIDDataGridViewTextBoxColumn
            // 
            this.cUSCIDDataGridViewTextBoxColumn.DataPropertyName = "CUS_C_ID";
            this.cUSCIDDataGridViewTextBoxColumn.HeaderText = "CUS_C_ID";
            this.cUSCIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSCIDDataGridViewTextBoxColumn.Name = "cUSCIDDataGridViewTextBoxColumn";
            this.cUSCIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSCID2DataGridViewTextBoxColumn
            // 
            this.cUSCID2DataGridViewTextBoxColumn.DataPropertyName = "CUS_C_ID2";
            this.cUSCID2DataGridViewTextBoxColumn.HeaderText = "CUS_C_ID2";
            this.cUSCID2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSCID2DataGridViewTextBoxColumn.Name = "cUSCID2DataGridViewTextBoxColumn";
            this.cUSCID2DataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSCID3DataGridViewTextBoxColumn
            // 
            this.cUSCID3DataGridViewTextBoxColumn.DataPropertyName = "CUS_C_ID3";
            this.cUSCID3DataGridViewTextBoxColumn.HeaderText = "CUS_C_ID3";
            this.cUSCID3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSCID3DataGridViewTextBoxColumn.Name = "cUSCID3DataGridViewTextBoxColumn";
            this.cUSCID3DataGridViewTextBoxColumn.Width = 125;
            // 
            // aDMINIDDataGridViewTextBoxColumn
            // 
            this.aDMINIDDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_ID";
            this.aDMINIDDataGridViewTextBoxColumn.HeaderText = "ADMIN_ID";
            this.aDMINIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDMINIDDataGridViewTextBoxColumn.Name = "aDMINIDDataGridViewTextBoxColumn";
            this.aDMINIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sIGADMINIDDataGridViewTextBoxColumn
            // 
            this.sIGADMINIDDataGridViewTextBoxColumn.DataPropertyName = "SIG_ADMIN_ID";
            this.sIGADMINIDDataGridViewTextBoxColumn.HeaderText = "SIG_ADMIN_ID";
            this.sIGADMINIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIGADMINIDDataGridViewTextBoxColumn.Name = "sIGADMINIDDataGridViewTextBoxColumn";
            this.sIGADMINIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cADDRESDataGridViewTextBoxColumn
            // 
            this.cADDRESDataGridViewTextBoxColumn.DataPropertyName = "C_ADDRES";
            this.cADDRESDataGridViewTextBoxColumn.HeaderText = "C_ADDRES";
            this.cADDRESDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cADDRESDataGridViewTextBoxColumn.Name = "cADDRESDataGridViewTextBoxColumn";
            this.cADDRESDataGridViewTextBoxColumn.Width = 125;
            // 
            // pURCHASESDataGridViewTextBoxColumn
            // 
            this.pURCHASESDataGridViewTextBoxColumn.DataPropertyName = "PURCHASES";
            this.pURCHASESDataGridViewTextBoxColumn.HeaderText = "PURCHASES";
            this.pURCHASESDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pURCHASESDataGridViewTextBoxColumn.Name = "pURCHASESDataGridViewTextBoxColumn";
            this.pURCHASESDataGridViewTextBoxColumn.Width = 125;
            // 
            // pURCHASESNUMDataGridViewTextBoxColumn
            // 
            this.pURCHASESNUMDataGridViewTextBoxColumn.DataPropertyName = "PURCHASES_NUM";
            this.pURCHASESNUMDataGridViewTextBoxColumn.HeaderText = "PURCHASES_NUM";
            this.pURCHASESNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pURCHASESNUMDataGridViewTextBoxColumn.Name = "pURCHASESNUMDataGridViewTextBoxColumn";
            this.pURCHASESNUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // lASTPURCHASDataGridViewImageColumn
            // 
            this.lASTPURCHASDataGridViewImageColumn.DataPropertyName = "LAST_PURCHAS";
            this.lASTPURCHASDataGridViewImageColumn.HeaderText = "LAST_PURCHAS";
            this.lASTPURCHASDataGridViewImageColumn.MinimumWidth = 6;
            this.lASTPURCHASDataGridViewImageColumn.Name = "lASTPURCHASDataGridViewImageColumn";
            this.lASTPURCHASDataGridViewImageColumn.ReadOnly = true;
            this.lASTPURCHASDataGridViewImageColumn.Width = 125;
            // 
            // button_info
            // 
            this.button_info.Location = new System.Drawing.Point(23, 40);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(88, 35);
            this.button_info.TabIndex = 1;
            this.button_info.Text = "Information";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(12, 470);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(99, 38);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(974, 520);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SuperMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private SuperMarketDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSCID2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSCID3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIGADMINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASESNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn lASTPURCHASDataGridViewImageColumn;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Button button_logout;
    }
}