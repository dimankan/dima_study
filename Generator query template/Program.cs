using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_игры_с_дизайнером.Static_classes;

namespace WinForms_игры_с_дизайнером
{


    class Program
    {
        [STAThread]
        static void Main()
        {
            #region Initialization Form

            Form myForm = new Form();


            Button butInitalElements = new Button();
            Button butSave = new Button();

            Button butSelectPath = new Button();

            TextBox textBoxSQL = new TextBox();
            TextBox textBoxNameTemp = new TextBox();
            TextBox textBoxPath = new TextBox();

            //For elements
            Label labelAlias = new Label();
            Label labelField = new Label();
            Label labelType = new Label();

            //Other
            Label labelSqlInput = new Label();
            Label labelPath = new Label();
            Label labelNameTemp = new Label();

            #region Designer

            // myForm
            myForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            myForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            myForm.ClientSize = new System.Drawing.Size(1031, 682);
            myForm.BackColor = System.Drawing.Color.Lavender;

            #region Button
            //butInitalElements - Генерация элементов
            butInitalElements.Location = new System.Drawing.Point(921, 44);
            butInitalElements.Size = new System.Drawing.Size(75, 23);
            butInitalElements.Text = "Generate";
            myForm.Controls.Add(butInitalElements);

            //butSave - Обработка измененной информации и сохранение
            butSave.Location = new System.Drawing.Point(921, 146);
            butSave.Size = new System.Drawing.Size(75, 23);
            butSave.Text = "Save";
            myForm.Controls.Add(butSave);

            //butSelectPath - Выбрать путь
            butSelectPath.Location = new System.Drawing.Point(221, 626);
            butSelectPath.Size = new System.Drawing.Size(75, 23);
            butSelectPath.Text = "Select";
            myForm.Controls.Add(butSelectPath);
            #endregion
            #region TextBox

            //textBoxSQL - ввод SQL запроса
            textBoxSQL.Location = new System.Drawing.Point(12, 42);
            textBoxSQL.Name = $"textBoxSQL.";
            textBoxSQL.Size = new System.Drawing.Size(284, 387);
            textBoxSQL.Multiline = true;
            myForm.Controls.Add(textBoxSQL);

            //textBoxPath - ввод поля
            textBoxPath.Location = new System.Drawing.Point(12, 562);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Multiline = true;
            textBoxPath.Size = new System.Drawing.Size(284, 58);
            textBoxPath.Text = @"C:\Users\Пользователь\Desktop\Query";
            myForm.Controls.Add(textBoxPath);

            //textBoxNameTemp - ввод имя шаблона
            textBoxNameTemp.Location = new System.Drawing.Point(12, 488);
            textBoxNameTemp.Name = "textBoxNameTemp";
            textBoxNameTemp.Size = new System.Drawing.Size(284, 20);
            textBoxNameTemp.Text = "test";
            myForm.Controls.Add(textBoxNameTemp);
            #endregion
            #region Label

            #region For elements
            // Label Alias
            labelAlias.AutoSize = true;
            labelAlias.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAlias.Location = new System.Drawing.Point(327, 13);
            labelAlias.Size = new System.Drawing.Size(60, 20);
            labelAlias.Text = "Алиас";
            myForm.Controls.Add(labelAlias);

            // Label Field
            labelField.AutoSize = true;
            labelField.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelField.Location = new System.Drawing.Point(455, 13);
            labelField.Size = new System.Drawing.Size(90, 20);
            labelField.Text = "Имя поля";
            myForm.Controls.Add(labelField);

            // Label Type
            labelType.AutoSize = true;
            labelType.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelType.Location = new System.Drawing.Point(590, 13);
            labelType.Size = new System.Drawing.Size(110, 20);
            labelType.Text = "Тип данных";
            myForm.Controls.Add(labelType);

            #endregion
            #region Other

            // Label SqlInput
            labelSqlInput.AutoSize = true;
            labelSqlInput.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSqlInput.Location = new System.Drawing.Point(12, 18);
            labelSqlInput.Size = new System.Drawing.Size(105, 21);
            labelSqlInput.Text = "SQL запрос";
            myForm.Controls.Add(labelSqlInput);

            // Label Path
            labelPath.AutoSize = true;
            labelPath.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPath.Location = new System.Drawing.Point(12, 538);
            labelPath.Size = new System.Drawing.Size(165, 21);
            labelPath.Text = "Адрес сохранения";
            myForm.Controls.Add(labelPath);

            // Label NameTemp
            labelNameTemp.AutoSize = true;
            labelNameTemp.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNameTemp.Location = new System.Drawing.Point(12, 464);
            labelNameTemp.Size = new System.Drawing.Size(124, 21);
            labelNameTemp.Text = "Имя шаблона";
            myForm.Controls.Add(labelNameTemp);

            #endregion
            #endregion
            #endregion
            #endregion

            #region Данные

            List<object> listAliasObject = new List<object>();
            List<object> listFieldsObject = new List<object>();
            List<object> listTypeObject = new List<object>();

            List<string> listAliasString = new List<string>();
            List<string> listFeildsString = new List<string>();
            List<string> listTypeString = new List<string>();

            #endregion

            #region Button.Click

            butInitalElements.Click += delegate
            {
                string[] alias = Separated.GetAlias(textBoxSQL.Text);
                string[] fields = Separated.GetFields(textBoxSQL.Text);

                listAliasObject = CreateElements.Alias(alias, myForm);
                listFieldsObject = CreateElements.Fields(fields, myForm);
                listTypeObject = CreateElements.Type(alias, myForm);
            };

            butSave.Click += delegate
            {
                listAliasString = DownCast.ToStingFromObject(listAliasObject);
                listFeildsString = DownCast.ToStingFromObject(listFieldsObject);
                listTypeString = DownCast.ToStingFromObject(listTypeObject);

                if (textBoxPath.Text == String.Empty || textBoxNameTemp.Text == String.Empty)
                    MessageBox.Show("Не указан адрес или имя для сохранения", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!Check.ForType(listTypeString))
                    MessageBox.Show("Укажите тип данных", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Templates.SaveFiles(textBoxPath.Text, textBoxNameTemp.Text, listAliasString, listFeildsString, listTypeString);
                    DialogResult result = MessageBox.Show("Файл сохранен!\nОткрыть файл?", "Сохранение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", $"{textBoxPath.Text}/{textBoxNameTemp.Text}.txt");
                    }
                }
            };

            butSelectPath.Click += delegate
            {
                textBoxPath.Text = Select.ChooseFolder(textBoxPath.Text);
            };
            #endregion

            Application.Run(myForm);
        }
    }
}
