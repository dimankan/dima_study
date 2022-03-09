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
            this.buttonRunDesign = new System.Windows.Forms.Button();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonWriteXml = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExportPDF = new System.Windows.Forms.Button();
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
            this.buttonRunDesign.Location = new System.Drawing.Point(143, 121);
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
            this.buttonShowReport.Location = new System.Drawing.Point(245, 121);
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
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к шаблону:";
            // 
            // tbPath
            // 
            this.tbPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(212)))));
            this.tbPath.Location = new System.Drawing.Point(41, 76);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
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
            this.buttonChooseFile.Location = new System.Drawing.Point(402, 63);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(96, 44);
            this.buttonChooseFile.TabIndex = 4;
            this.buttonChooseFile.Text = "Выбрать шаблон";
            this.buttonChooseFile.UseVisualStyleBackColor = false;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(212)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 93);
            this.dataGridView1.TabIndex = 5;
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
            this.buttonWriteXml.Location = new System.Drawing.Point(41, 121);
            this.buttonWriteXml.Name = "buttonWriteXml";
            this.buttonWriteXml.Size = new System.Drawing.Size(96, 36);
            this.buttonWriteXml.TabIndex = 1;
            this.buttonWriteXml.Text = "WriteXml";
            this.buttonWriteXml.UseVisualStyleBackColor = false;
            this.buttonWriteXml.Click += new System.EventHandler(this.buttonWriteXml_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбрать шаблон:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(212)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1125008 RFNDocRequestOrg",
            "1123303 RFNDocRequestBank"});
            this.comboBox1.Location = new System.Drawing.Point(41, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(533, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "v.1";
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(127)))), ((int)(((byte)(108)))));
            this.buttonExportPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.buttonExportPDF.FlatAppearance.BorderSize = 3;
            this.buttonExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonExportPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.buttonExportPDF.Location = new System.Drawing.Point(347, 121);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(96, 36);
            this.buttonExportPDF.TabIndex = 1;
            this.buttonExportPDF.Text = "Скачать PDF";
            this.buttonExportPDF.UseVisualStyleBackColor = false;
            this.buttonExportPDF.Click += new System.EventHandler(this.buttonExportPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(103)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(553, 265);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWriteXml);
            this.Controls.Add(this.buttonExportPDF);
            this.Controls.Add(this.buttonShowReport);
            this.Controls.Add(this.buttonRunDesign);
            this.Name = "Form1";
            this.Text = "Stimulsoft47";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonWriteXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExportPDF;
    }
}

