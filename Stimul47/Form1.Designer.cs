namespace Stimul47
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonRunDesign = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataSet1 = new Stimul47.Data.DataSet1();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faceshortNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceshortINNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceshortKPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceshortKIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceshortADRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pervdocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pervdocnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pervdocdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasondocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docsrokdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typerequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docorgnaimcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docorgadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docdolrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docorgnaimRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docchinrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docfiorukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docpoluchilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docsrokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docUserFioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docUserPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docUserEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRunDesign
            // 
            this.buttonRunDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(127)))), ((int)(((byte)(108)))));
            this.buttonRunDesign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.buttonRunDesign.FlatAppearance.BorderSize = 3;
            this.buttonRunDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunDesign.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRunDesign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.buttonRunDesign.Location = new System.Drawing.Point(15, 72);
            this.buttonRunDesign.Name = "buttonRunDesign";
            this.buttonRunDesign.Size = new System.Drawing.Size(96, 36);
            this.buttonRunDesign.TabIndex = 0;
            this.buttonRunDesign.Text = "Дизайнер";
            this.buttonRunDesign.UseVisualStyleBackColor = false;
            this.buttonRunDesign.Click += new System.EventHandler(this.buttonRunDesign_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(127)))), ((int)(((byte)(108)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.button2.Location = new System.Drawing.Point(136, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Просмотреть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к шаблону:";
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(212)))));
            this.tbPath.Location = new System.Drawing.Point(15, 27);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(355, 20);
            this.tbPath.TabIndex = 3;
            this.tbPath.Text = "C:\\Users\\ASUS\\OneDrive\\Рабочий стол\\from rtf.mrt";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(127)))), ((int)(((byte)(108)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.button3.Location = new System.Drawing.Point(376, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Выбрать шаблон";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faceshortNAMEDataGridViewTextBoxColumn,
            this.faceshortINNDataGridViewTextBoxColumn,
            this.faceshortKPPDataGridViewTextBoxColumn,
            this.faceshortKIODataGridViewTextBoxColumn,
            this.faceshortADRDataGridViewTextBoxColumn,
            this.docnumDataGridViewTextBoxColumn,
            this.pervdocDataGridViewTextBoxColumn,
            this.pervdocnumDataGridViewTextBoxColumn,
            this.pervdocdateDataGridViewTextBoxColumn,
            this.docdateDataGridViewTextBoxColumn,
            this.faceDataGridViewTextBoxColumn,
            this.reasondocDataGridViewTextBoxColumn,
            this.docsrokdDataGridViewTextBoxColumn,
            this.typerequestDataGridViewTextBoxColumn,
            this.docorgnaimcodeDataGridViewTextBoxColumn,
            this.docorgadresDataGridViewTextBoxColumn,
            this.docsDataGridViewTextBoxColumn,
            this.docdolrukDataGridViewTextBoxColumn,
            this.docorgnaimRDataGridViewTextBoxColumn,
            this.docchinrukDataGridViewTextBoxColumn,
            this.docfiorukDataGridViewTextBoxColumn,
            this.docpoluchilDataGridViewTextBoxColumn,
            this.docsrokDataGridViewTextBoxColumn,
            this.docUserFioDataGridViewTextBoxColumn,
            this.docUserPhoneDataGridViewTextBoxColumn,
            this.docUserEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // faceshortNAMEDataGridViewTextBoxColumn
            // 
            this.faceshortNAMEDataGridViewTextBoxColumn.DataPropertyName = "Face_short_NAME";
            this.faceshortNAMEDataGridViewTextBoxColumn.HeaderText = "Face_short_NAME";
            this.faceshortNAMEDataGridViewTextBoxColumn.Name = "faceshortNAMEDataGridViewTextBoxColumn";
            this.faceshortNAMEDataGridViewTextBoxColumn.Width = 122;
            // 
            // faceshortINNDataGridViewTextBoxColumn
            // 
            this.faceshortINNDataGridViewTextBoxColumn.DataPropertyName = "Face_short_INN";
            this.faceshortINNDataGridViewTextBoxColumn.HeaderText = "Face_short_INN";
            this.faceshortINNDataGridViewTextBoxColumn.Name = "faceshortINNDataGridViewTextBoxColumn";
            this.faceshortINNDataGridViewTextBoxColumn.Width = 110;
            // 
            // faceshortKPPDataGridViewTextBoxColumn
            // 
            this.faceshortKPPDataGridViewTextBoxColumn.DataPropertyName = "Face_short_KPP";
            this.faceshortKPPDataGridViewTextBoxColumn.HeaderText = "Face_short_KPP";
            this.faceshortKPPDataGridViewTextBoxColumn.Name = "faceshortKPPDataGridViewTextBoxColumn";
            this.faceshortKPPDataGridViewTextBoxColumn.Width = 112;
            // 
            // faceshortKIODataGridViewTextBoxColumn
            // 
            this.faceshortKIODataGridViewTextBoxColumn.DataPropertyName = "Face_short_KIO";
            this.faceshortKIODataGridViewTextBoxColumn.HeaderText = "Face_short_KIO";
            this.faceshortKIODataGridViewTextBoxColumn.Name = "faceshortKIODataGridViewTextBoxColumn";
            this.faceshortKIODataGridViewTextBoxColumn.Width = 109;
            // 
            // faceshortADRDataGridViewTextBoxColumn
            // 
            this.faceshortADRDataGridViewTextBoxColumn.DataPropertyName = "Face_short_ADR";
            this.faceshortADRDataGridViewTextBoxColumn.HeaderText = "Face_short_ADR";
            this.faceshortADRDataGridViewTextBoxColumn.Name = "faceshortADRDataGridViewTextBoxColumn";
            this.faceshortADRDataGridViewTextBoxColumn.Width = 114;
            // 
            // docnumDataGridViewTextBoxColumn
            // 
            this.docnumDataGridViewTextBoxColumn.DataPropertyName = "doc_num";
            this.docnumDataGridViewTextBoxColumn.HeaderText = "doc_num";
            this.docnumDataGridViewTextBoxColumn.Name = "docnumDataGridViewTextBoxColumn";
            this.docnumDataGridViewTextBoxColumn.Width = 76;
            // 
            // pervdocDataGridViewTextBoxColumn
            // 
            this.pervdocDataGridViewTextBoxColumn.DataPropertyName = "perv_doc";
            this.pervdocDataGridViewTextBoxColumn.HeaderText = "perv_doc";
            this.pervdocDataGridViewTextBoxColumn.Name = "pervdocDataGridViewTextBoxColumn";
            this.pervdocDataGridViewTextBoxColumn.Width = 77;
            // 
            // pervdocnumDataGridViewTextBoxColumn
            // 
            this.pervdocnumDataGridViewTextBoxColumn.DataPropertyName = "perv_doc_num";
            this.pervdocnumDataGridViewTextBoxColumn.HeaderText = "perv_doc_num";
            this.pervdocnumDataGridViewTextBoxColumn.Name = "pervdocnumDataGridViewTextBoxColumn";
            this.pervdocnumDataGridViewTextBoxColumn.Width = 103;
            // 
            // pervdocdateDataGridViewTextBoxColumn
            // 
            this.pervdocdateDataGridViewTextBoxColumn.DataPropertyName = "perv_doc_date";
            this.pervdocdateDataGridViewTextBoxColumn.HeaderText = "perv_doc_date";
            this.pervdocdateDataGridViewTextBoxColumn.Name = "pervdocdateDataGridViewTextBoxColumn";
            this.pervdocdateDataGridViewTextBoxColumn.Width = 104;
            // 
            // docdateDataGridViewTextBoxColumn
            // 
            this.docdateDataGridViewTextBoxColumn.DataPropertyName = "doc_date";
            this.docdateDataGridViewTextBoxColumn.HeaderText = "doc_date";
            this.docdateDataGridViewTextBoxColumn.Name = "docdateDataGridViewTextBoxColumn";
            this.docdateDataGridViewTextBoxColumn.Width = 77;
            // 
            // faceDataGridViewTextBoxColumn
            // 
            this.faceDataGridViewTextBoxColumn.DataPropertyName = "Face";
            this.faceDataGridViewTextBoxColumn.HeaderText = "Face";
            this.faceDataGridViewTextBoxColumn.Name = "faceDataGridViewTextBoxColumn";
            this.faceDataGridViewTextBoxColumn.Width = 56;
            // 
            // reasondocDataGridViewTextBoxColumn
            // 
            this.reasondocDataGridViewTextBoxColumn.DataPropertyName = "reason_doc";
            this.reasondocDataGridViewTextBoxColumn.HeaderText = "reason_doc";
            this.reasondocDataGridViewTextBoxColumn.Name = "reasondocDataGridViewTextBoxColumn";
            this.reasondocDataGridViewTextBoxColumn.Width = 88;
            // 
            // docsrokdDataGridViewTextBoxColumn
            // 
            this.docsrokdDataGridViewTextBoxColumn.DataPropertyName = "doc_srokd";
            this.docsrokdDataGridViewTextBoxColumn.HeaderText = "doc_srokd";
            this.docsrokdDataGridViewTextBoxColumn.Name = "docsrokdDataGridViewTextBoxColumn";
            this.docsrokdDataGridViewTextBoxColumn.Width = 82;
            // 
            // typerequestDataGridViewTextBoxColumn
            // 
            this.typerequestDataGridViewTextBoxColumn.DataPropertyName = "type_request";
            this.typerequestDataGridViewTextBoxColumn.HeaderText = "type_request";
            this.typerequestDataGridViewTextBoxColumn.Name = "typerequestDataGridViewTextBoxColumn";
            this.typerequestDataGridViewTextBoxColumn.Width = 93;
            // 
            // docorgnaimcodeDataGridViewTextBoxColumn
            // 
            this.docorgnaimcodeDataGridViewTextBoxColumn.DataPropertyName = "doc_org_naim_code";
            this.docorgnaimcodeDataGridViewTextBoxColumn.HeaderText = "doc_org_naim_code";
            this.docorgnaimcodeDataGridViewTextBoxColumn.Name = "docorgnaimcodeDataGridViewTextBoxColumn";
            this.docorgnaimcodeDataGridViewTextBoxColumn.Width = 129;
            // 
            // docorgadresDataGridViewTextBoxColumn
            // 
            this.docorgadresDataGridViewTextBoxColumn.DataPropertyName = "doc_org_adres";
            this.docorgadresDataGridViewTextBoxColumn.HeaderText = "doc_org_adres";
            this.docorgadresDataGridViewTextBoxColumn.Name = "docorgadresDataGridViewTextBoxColumn";
            this.docorgadresDataGridViewTextBoxColumn.Width = 103;
            // 
            // docsDataGridViewTextBoxColumn
            // 
            this.docsDataGridViewTextBoxColumn.DataPropertyName = "Docs";
            this.docsDataGridViewTextBoxColumn.HeaderText = "Docs";
            this.docsDataGridViewTextBoxColumn.Name = "docsDataGridViewTextBoxColumn";
            this.docsDataGridViewTextBoxColumn.Width = 57;
            // 
            // docdolrukDataGridViewTextBoxColumn
            // 
            this.docdolrukDataGridViewTextBoxColumn.DataPropertyName = "doc_dolruk";
            this.docdolrukDataGridViewTextBoxColumn.HeaderText = "doc_dolruk";
            this.docdolrukDataGridViewTextBoxColumn.Name = "docdolrukDataGridViewTextBoxColumn";
            this.docdolrukDataGridViewTextBoxColumn.Width = 85;
            // 
            // docorgnaimRDataGridViewTextBoxColumn
            // 
            this.docorgnaimRDataGridViewTextBoxColumn.DataPropertyName = "doc_org_naimR";
            this.docorgnaimRDataGridViewTextBoxColumn.HeaderText = "doc_org_naimR";
            this.docorgnaimRDataGridViewTextBoxColumn.Name = "docorgnaimRDataGridViewTextBoxColumn";
            this.docorgnaimRDataGridViewTextBoxColumn.Width = 107;
            // 
            // docchinrukDataGridViewTextBoxColumn
            // 
            this.docchinrukDataGridViewTextBoxColumn.DataPropertyName = "doc_chinruk";
            this.docchinrukDataGridViewTextBoxColumn.HeaderText = "doc_chinruk";
            this.docchinrukDataGridViewTextBoxColumn.Name = "docchinrukDataGridViewTextBoxColumn";
            this.docchinrukDataGridViewTextBoxColumn.Width = 91;
            // 
            // docfiorukDataGridViewTextBoxColumn
            // 
            this.docfiorukDataGridViewTextBoxColumn.DataPropertyName = "doc_fioruk";
            this.docfiorukDataGridViewTextBoxColumn.HeaderText = "doc_fioruk";
            this.docfiorukDataGridViewTextBoxColumn.Name = "docfiorukDataGridViewTextBoxColumn";
            this.docfiorukDataGridViewTextBoxColumn.Width = 82;
            // 
            // docpoluchilDataGridViewTextBoxColumn
            // 
            this.docpoluchilDataGridViewTextBoxColumn.DataPropertyName = "doc_poluchil";
            this.docpoluchilDataGridViewTextBoxColumn.HeaderText = "doc_poluchil";
            this.docpoluchilDataGridViewTextBoxColumn.Name = "docpoluchilDataGridViewTextBoxColumn";
            this.docpoluchilDataGridViewTextBoxColumn.Width = 92;
            // 
            // docsrokDataGridViewTextBoxColumn
            // 
            this.docsrokDataGridViewTextBoxColumn.DataPropertyName = "doc_srok";
            this.docsrokDataGridViewTextBoxColumn.HeaderText = "doc_srok";
            this.docsrokDataGridViewTextBoxColumn.Name = "docsrokDataGridViewTextBoxColumn";
            this.docsrokDataGridViewTextBoxColumn.Width = 76;
            // 
            // docUserFioDataGridViewTextBoxColumn
            // 
            this.docUserFioDataGridViewTextBoxColumn.DataPropertyName = "DocUserFio";
            this.docUserFioDataGridViewTextBoxColumn.HeaderText = "DocUserFio";
            this.docUserFioDataGridViewTextBoxColumn.Name = "docUserFioDataGridViewTextBoxColumn";
            this.docUserFioDataGridViewTextBoxColumn.Width = 88;
            // 
            // docUserPhoneDataGridViewTextBoxColumn
            // 
            this.docUserPhoneDataGridViewTextBoxColumn.DataPropertyName = "DocUserPhone";
            this.docUserPhoneDataGridViewTextBoxColumn.HeaderText = "DocUserPhone";
            this.docUserPhoneDataGridViewTextBoxColumn.Name = "docUserPhoneDataGridViewTextBoxColumn";
            this.docUserPhoneDataGridViewTextBoxColumn.Width = 105;
            // 
            // docUserEmailDataGridViewTextBoxColumn
            // 
            this.docUserEmailDataGridViewTextBoxColumn.DataPropertyName = "DocUserEmail";
            this.docUserEmailDataGridViewTextBoxColumn.HeaderText = "DocUserEmail";
            this.docUserEmailDataGridViewTextBoxColumn.Name = "docUserEmailDataGridViewTextBoxColumn";
            this.docUserEmailDataGridViewTextBoxColumn.Width = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(103)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1009, 722);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRunDesign);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRunDesign;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceshortNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceshortINNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceshortKPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceshortKIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceshortADRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pervdocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pervdocnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pervdocdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasondocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docsrokdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typerequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docorgnaimcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docorgadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docdolrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docorgnaimRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docchinrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docfiorukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docpoluchilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docsrokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docUserFioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docUserPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docUserEmailDataGridViewTextBoxColumn;
    }
}

