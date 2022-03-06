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
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.buttonChooseFile = new System.Windows.Forms.Button();
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
            this.buttonWriteXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRunDesign
            // 
            this.buttonRunDesign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRunDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(127)))), ((int)(((byte)(108)))));
            this.buttonRunDesign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.buttonRunDesign.FlatAppearance.BorderSize = 3;
            this.buttonRunDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunDesign.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRunDesign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.buttonRunDesign.Location = new System.Drawing.Point(153, 67);
            this.buttonRunDesign.Name = "buttonRunDesign";
            this.buttonRunDesign.Size = new System.Drawing.Size(96, 36);
            this.buttonRunDesign.TabIndex = 0;
            this.buttonRunDesign.Text = "Дизайнер";
            this.buttonRunDesign.UseVisualStyleBackColor = false;
            this.buttonRunDesign.Click += new System.EventHandler(this.buttonRunDesign_Click);
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(127)))), ((int)(((byte)(108)))));
            this.buttonShowReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.buttonShowReport.FlatAppearance.BorderSize = 3;
            this.buttonShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonShowReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.buttonShowReport.Location = new System.Drawing.Point(255, 67);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(96, 36);
            this.buttonShowReport.TabIndex = 1;
            this.buttonShowReport.Text = "Просмотреть";
            this.buttonShowReport.UseVisualStyleBackColor = false;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShowReport_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(48, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к шаблону:";
            // 
            // tbPath
            // 
            this.tbPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(212)))));
            this.tbPath.Location = new System.Drawing.Point(51, 22);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(355, 20);
            this.tbPath.TabIndex = 3;
            this.tbPath.Text = "C:\\Users\\ASUS\\OneDrive\\Рабочий стол\\from rtf.mrt";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(127)))), ((int)(((byte)(108)))));
            this.buttonChooseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.buttonChooseFile.FlatAppearance.BorderSize = 3;
            this.buttonChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonChooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.buttonChooseFile.Location = new System.Drawing.Point(412, 9);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(96, 44);
            this.buttonChooseFile.TabIndex = 4;
            this.buttonChooseFile.Text = "Выбрать шаблон";
            this.buttonChooseFile.UseVisualStyleBackColor = false;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(212)))));
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 93);
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
            // buttonWriteXml
            // 
            this.buttonWriteXml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWriteXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(127)))), ((int)(((byte)(108)))));
            this.buttonWriteXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.buttonWriteXml.FlatAppearance.BorderSize = 3;
            this.buttonWriteXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWriteXml.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonWriteXml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.buttonWriteXml.Location = new System.Drawing.Point(51, 67);
            this.buttonWriteXml.Name = "buttonWriteXml";
            this.buttonWriteXml.Size = new System.Drawing.Size(96, 36);
            this.buttonWriteXml.TabIndex = 1;
            this.buttonWriteXml.Text = "WriteXml";
            this.buttonWriteXml.UseVisualStyleBackColor = false;
            this.buttonWriteXml.Click += new System.EventHandler(this.buttonWriteXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(103)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(550, 202);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWriteXml);
            this.Controls.Add(this.buttonShowReport);
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
        private System.Windows.Forms.Button buttonShowReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button buttonChooseFile;
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
        private System.Windows.Forms.Button buttonWriteXml;
    }
}

