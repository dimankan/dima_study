using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_игры_с_дизайнером
{

    #region ReservCopy
    #region Trash
    //static class Program
    //{
    //    /// <summary>
    //    /// Главная точка входа для приложения.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        Application.Run(new Form1());
    //    }
    //}

    //class Worker : INotifyPropertyChanged
    //{

    //    string name;
    //    public string Name
    //    {
    //        get => name;
    //        set
    //        {
    //            name = value;

    //        }
    //    }

    //    public void A()
    //    {
    //        PropertyChanged?.Invoke(this,
    //               new PropertyChangedEventArgs(nameof(Name))
    //                );
    //    }
    //    public string Name1 { get; set; }
    //    public string Name3 { get; set; }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //}

    //Worker w = new Worker { Name = "ЙЦУ" };

    //button.Click += delegate
    //{
    //    w.Name += "+++";
    //    f.Text = w.Name;
    //};


    //var b = new Binding("Text", w, "Name");


    // 
    // domainUpDown2
    // 
    //            this.domainUpDown2.Location = new System.Drawing.Point(332, 74);
    //            this.domainUpDown2.Name = "domainUpDown2";
    //            this.domainUpDown2.Size = new System.Drawing.Size(120, 20);
    //            this.domainUpDown2.TabIndex = 5;
    //            this.domainUpDown2.Text = "domainUpDown2";
    //            this.domainUpDown2.Items.AddRange(new object[] {
    //            "one",
    //            "two",
    //            "three"});
    //// 
    //// listBox1
    //// 
    //this.listBox1.FormattingEnabled = true;
    //this.listBox1.Items.AddRange(new object[] {
    //            "one",
    //            "two",
    //            "three"});
    //this.listBox1.Location = new System.Drawing.Point(140, 216);
    //this.listBox1.Name = "listBox1";
    //this.listBox1.Size = new System.Drawing.Size(93, 56);
    //this.listBox1.TabIndex = 6;

    //                this.comboBox1.FormattingEnabled = true;
    //            this.comboBox1.Items.AddRange(new object[] {
    //            "one",
    //            "two",
    //            "three"});
    //this.comboBox1.Location = new System.Drawing.Point(349, 121);
    //this.comboBox1.Name = "comboBox1";
    //this.comboBox1.Size = new System.Drawing.Size(121, 21);
    //this.comboBox1.TabIndex = 3;

    #endregion
    #region Base
    //static void Main()
    //{
    //    Form f = new Form();
    //    TextBox textBox1 = new TextBox();
    //    TextBox textBox2 = new TextBox();
    //    Button button1 = new Button();

    //    #region Designer
    //    f.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //    f.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //    f.ClientSize = new System.Drawing.Size(845, 470);


    //    textBox1.Location = new System.Drawing.Point(75, 75);
    //    textBox1.Name = "textBox1";
    //    textBox1.Size = new System.Drawing.Size(100, 20);
    //    textBox1.TabIndex = 0;
    //    f.Controls.Add(textBox1);

    //    textBox2.Location = new System.Drawing.Point(200, 75);
    //    textBox2.Name = "textBox2";
    //    textBox2.Size = new System.Drawing.Size(100, 20);
    //    textBox2.TabIndex = 0;
    //    f.Controls.Add(textBox2);


    //    button1.Location = new System.Drawing.Point(517, 75);
    //    button1.Name = "button1";
    //    button1.Size = new System.Drawing.Size(75, 23);
    //    button1.TabIndex = 1;
    //    button1.Text = "button1";
    //    button1.UseVisualStyleBackColor = true;
    //    f.Controls.Add(button1);





    //    //this.Controls.Add(this.button1);
    //    //this.Name = "Form1";
    //    //this.Text = "Form1";
    //    //this.ResumeLayout(false);
    //    //this.PerformLayout();
    //    #endregion
    //    //button.Top = 50;

    //    //tx.DataBindings.Add(b);

    //    //f.Controls.Add(tx);
    //    Application.Run(f);



    //}

    #endregion
    #region Base#2
    //class Program
    //{
    //    static void Main()
    //    {
    //        Form f = new Form();
    //        Button button1 = new Button();

    //        #region Designer

    //        f.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        f.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        f.ClientSize = new System.Drawing.Size(845, 470);

    //        button1.Location = new System.Drawing.Point(517, 75);
    //        button1.Name = "button1";
    //        button1.Size = new System.Drawing.Size(75, 23);
    //        button1.TabIndex = 1;
    //        button1.Text = "button1";
    //        button1.UseVisualStyleBackColor = true;
    //        f.Controls.Add(button1);

    //        #endregion

    //        List<object> list1 = new List<object>();
    //        List<object> list2 = new List<object>();
    //        List<object> list3 = new List<object>();

    //        int i = 0;
    //        int n = 75;

    //        button1.Click += delegate
    //        {
    //            list1.Add(new TextBox()
    //            {
    //                Location = new System.Drawing.Point(75, n),
    //                Name = $"textBox1.{i}",
    //                Size = new System.Drawing.Size(100, 20),

    //            });
    //            f.Controls.Add(list1[i] as TextBox);

    //            list2.Add(new TextBox()
    //            {
    //                Location = new System.Drawing.Point(200, n),
    //                Name = $"textBox2.{i}",
    //                Size = new System.Drawing.Size(100, 20),

    //            });
    //            f.Controls.Add(list2[i] as TextBox);


    //            list3.Add(new ComboBox()
    //            {
    //                DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList,
    //                Location = new System.Drawing.Point(340, n),
    //                Name = $"domainUpDown2.{i}",
    //                Size = new System.Drawing.Size(120, 20),
    //            });

    //            (list3[i] as ComboBox).Items.AddRange(new object[] { "one", "two", "three" });

    //            f.Controls.Add(list3[i] as ComboBox);

    //            i++;
    //            n += 25;
    //        };
    //        Application.Run(f);
    //    }
    //}
    #endregion
    #region Base#3
    //class Separated
    //{
    //    /// <summary>
    //    /// Получаем первичный массив с атрибутами, где алиасы еще не разделены
    //    /// </summary>
    //    /// <param name="str">Первичный запрос</param>
    //    /// <returns></returns>
    //    public string[] FiltredTrash(string str)
    //    {
    //        string[] mas1 = str.Split(' ', ',', '\n');
    //        List<string> list = new List<string>();

    //        foreach (var item in mas1)
    //        {
    //            Regex regex = new Regex("[.]");
    //            bool match = regex.IsMatch(item);
    //            if (match)
    //                list.Add(item);
    //        }
    //        return list.ToArray();
    //    }
    //    /// <summary>
    //    /// Разделяет массив на двумерный. Алиас и имя поля.
    //    /// </summary>
    //    /// <param name="mas"></param>
    //    /// <returns></returns>
    //    public string[,] SeparatDot(string[] mas)
    //    {
    //        string[,] result = new string[mas.Length, 2];
    //        for (int i = 0; i < mas.Length; i++)
    //        {
    //            int index = mas[i].IndexOf('.');
    //            result[i, 0] = mas[i].Substring(0, mas.Length - index + 1);
    //            result[i, 1] = mas[i].Substring(index + 1);
    //        }
    //        return result;
    //    }
    //}
    //public class CreateElements
    //{
    //    /// <summary>
    //    /// Создает элементы. Необходимо добавить входной парамметр, который регулировал количество строк
    //    /// </summary>
    //    /// <param name="f">форма</param>
    //    /// <returns></returns>
    //    public static List<List<object>> Elements(/*string[,] array,*/ Form f)
    //    {
    //        List<object> list1 = new List<object>();
    //        List<object> list2 = new List<object>();
    //        List<object> list3 = new List<object>();


    //        //int n = 75;
    //        for (int i = 0, n = 75; i < 5; i++, n += 25)
    //        {
    //            list1.Add(new TextBox()
    //            {
    //                Location = new System.Drawing.Point(75, n),
    //                Name = $"textBox1.{i}",
    //                Size = new System.Drawing.Size(100, 20),

    //            });
    //            f.Controls.Add(list1[i] as TextBox);

    //            list2.Add(new TextBox()
    //            {
    //                Location = new System.Drawing.Point(200, n),
    //                Name = $"textBox2.{i}",
    //                Size = new System.Drawing.Size(100, 20),

    //            });
    //            f.Controls.Add(list2[i] as TextBox);


    //            list3.Add(new ComboBox()
    //            {
    //                DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList,
    //                Location = new System.Drawing.Point(340, n),
    //                Name = $"domainUpDown1.{i}",
    //                Size = new System.Drawing.Size(120, 20),
    //            });

    //            (list3[i] as ComboBox).Items.AddRange(new object[] { "one", "two", "three" });

    //            f.Controls.Add(list3[i] as ComboBox);

    //        }
    //        List<List<object>> result = new List<List<object>>() { list1, list2, list3 };
    //        return result;

    //    }
    //    /// <summary>
    //    /// Перевод из object в string
    //    /// </summary>
    //    /// <param name="listObjet"></param>
    //    /// <returns></returns>
    //    public static List<List<string>> ToStingFromTextBox(List<List<object>> listObjet)
    //    {
    //        List<List<string>> listString = new List<List<string>>();
    //        List<string> subListString = new List<string>();
    //        for (int i = 0; i < listObjet.Count; i++)
    //        {
    //            for (int n = 0; n < listObjet[i].Count; n++)
    //            {
    //                if (listObjet[i][n] is TextBox)
    //                    subListString.Add((listObjet[i][n] as TextBox).Text);
    //                else if (listObjet[i][n] is ComboBox)
    //                    subListString.Add((listObjet[i][n] as ComboBox).Text);
    //            }
    //            listString.Add(subListString);

    //        }
    //        return listString;
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        Form f = new Form();
    //        Button button1 = new Button();
    //        Button butSave = new Button();
    //        TextBox textBox = new TextBox()
    //        {
    //            Location = new System.Drawing.Point(15, 10),
    //            Name = $"textBox1.",
    //            Size = new System.Drawing.Size(1000, 110),

    //        };
    //        f.Controls.Add(textBox);

    //        #region Designer

    //        f.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        f.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        f.ClientSize = new System.Drawing.Size(845, 470);

    //        button1.Location = new System.Drawing.Point(517, 75);
    //        button1.Name = "button1";
    //        button1.Size = new System.Drawing.Size(75, 23);
    //        button1.Text = "button1";
    //        button1.UseVisualStyleBackColor = true;
    //        f.Controls.Add(button1);

    //        butSave.Location = new System.Drawing.Point(517, 175);
    //        butSave.Name = "butSave";
    //        butSave.Size = new System.Drawing.Size(75, 23);
    //        butSave.TabIndex = 1;
    //        butSave.Text = "butSave";
    //        butSave.UseVisualStyleBackColor = true;
    //        f.Controls.Add(butSave);

    //        #endregion

    //        List<List<object>> listComplexObject = new List<List<object>>();
    //        List<List<string>> listComplexString = new List<List<string>>();

    //        button1.Click += delegate
    //        {
    //            listComplexObject = CreateElements.Elements(f);
    //        };

    //        butSave.Click += delegate
    //        {
    //            //System.Windows.Forms.TextBox, Text: das;System.Windows.Forms.TextBox, Text: sad;System.Windows.Forms.TextBox, Text: qwqd;
    //            //textBox.Text = string.Join(";", (listComplex[0][0] as TextBox).Text);
    //            listComplexString = CreateElements.ToStingFromTextBox(listComplexObject);
    //            textBox.Text = string.Join(";", listComplexString[0]);

    //        };
    //        Application.Run(f);
    //    }
    //}
    #endregion
    #region Base#4
    //public class Separated
    //{
    //    /// <summary>
    //    /// Получаем первичный массив с атрибутами, где алиасы еще не разделены
    //    /// </summary>
    //    /// <param name="str">Первичный запрос</param>
    //    /// <returns></returns>
    //    public static string[] FiltredTrash(string str)
    //    {
    //        string[] mas1 = str.Split(' ', ',', '\n');
    //        List<string> list = new List<string>();

    //        foreach (var item in mas1)
    //        {
    //            Regex regex = new Regex("[.]");
    //            bool match = regex.IsMatch(item);
    //            if (match)
    //                list.Add(item);
    //        }
    //        return list.ToArray();
    //    }
    //    /// <summary>
    //    /// Разделяет массив на двумерный. Алиас и имя поля.
    //    /// </summary>
    //    /// <param name="mas"></param>
    //    /// <returns></returns>
    //    public static string[,] SeparatDot(string[] mas)
    //    {
    //        string[,] result = new string[mas.Length, 2];
    //        for (int i = 0; i < mas.Length; i++)
    //        {
    //            int index = mas[i].IndexOf('.');
    //            result[i, 0] = mas[i].Substring(0, mas.Length - index + 1);
    //            result[i, 1] = mas[i].Substring(index + 1);
    //        }
    //        return result;
    //    }
    //}
    //public class CreateElements
    //{
    //    /// <summary>
    //    /// Создает элементы. Необходимо добавить входной парамметр, который регулировал количество строк
    //    /// </summary>
    //    /// <param name="f">форма</param>
    //    /// <returns></returns>
    //    public static List<List<object>> Elements(string[,] array, Form f)
    //    {
    //        List<object> list1 = new List<object>();
    //        List<object> list2 = new List<object>();
    //        List<object> list3 = new List<object>();


    //        //int n = 75;
    //        for (int i = 0, n = 75; i < array.GetLength(0); i++, n += 25)
    //        {
    //            list1.Add(new TextBox()
    //            {
    //                Location = new System.Drawing.Point(75, n),
    //                Name = $"textBox1.{i}",
    //                Size = new System.Drawing.Size(100, 20),
    //                Text = array[i, 0]

    //            }); ;
    //            f.Controls.Add(list1[i] as TextBox);

    //            list2.Add(new TextBox()
    //            {
    //                Location = new System.Drawing.Point(200, n),
    //                Name = $"textBox2.{i}",
    //                Size = new System.Drawing.Size(100, 20),
    //                Text = array[i, 1]


    //            });
    //            f.Controls.Add(list2[i] as TextBox);


    //            list3.Add(new ComboBox()
    //            {
    //                DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList,
    //                Location = new System.Drawing.Point(340, n),
    //                Name = $"domainUpDown1.{i}",
    //                Size = new System.Drawing.Size(120, 20),
    //            });

    //            (list3[i] as ComboBox).Items.AddRange(new object[] { "one", "two", "three" });

    //            f.Controls.Add(list3[i] as ComboBox);

    //        }
    //        List<List<object>> result = new List<List<object>>() { list1, list2, list3 };
    //        return result;

    //    }
    //    /// <summary>
    //    /// Перевод из object в string
    //    /// </summary>
    //    /// <param name="listObjet"></param>
    //    /// <returns></returns>
    //    public static List<List<string>> ToStingFromTextBox(List<List<object>> listObjet)
    //    {
    //        List<List<string>> listString = new List<List<string>>();
    //        List<string> subListString = new List<string>();
    //        for (int i = 0; i < listObjet.Count; i++)
    //        {
    //            for (int n = 0; n < listObjet[i].Count; n++)
    //            {
    //                if (listObjet[i][n] is TextBox)
    //                    subListString.Add((listObjet[i][n] as TextBox).Text);
    //                else if (listObjet[i][n] is ComboBox)
    //                    subListString.Add((listObjet[i][n] as ComboBox).Text);
    //            }
    //            listString.Add(subListString);

    //        }
    //        return listString;
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {

    //        #region Initialization
    //        Form f = new Form();
    //        Button button1 = new Button();
    //        Button butSave = new Button();
    //        TextBox textBox1 = new TextBox();
    //        TextBox textBox2 = new TextBox();

    //        #region Designer

    //        f.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        f.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        f.ClientSize = new System.Drawing.Size(845, 470);

    //        button1.Location = new System.Drawing.Point(517, 75);
    //        button1.Name = "button1";
    //        button1.Size = new System.Drawing.Size(75, 23);
    //        button1.Text = "button1";
    //        button1.UseVisualStyleBackColor = true;
    //        f.Controls.Add(button1);

    //        butSave.Location = new System.Drawing.Point(517, 175);
    //        butSave.Name = "butSave";
    //        butSave.Size = new System.Drawing.Size(75, 23);
    //        butSave.TabIndex = 1;
    //        butSave.Text = "butSave";
    //        butSave.UseVisualStyleBackColor = true;
    //        f.Controls.Add(butSave);

    //        textBox1.Location = new System.Drawing.Point(15, 10);
    //        textBox1.Name = $"textBox1.";
    //        textBox1.Size = new System.Drawing.Size(800, 110);
    //        f.Controls.Add(textBox1);

    //        textBox2.Location = new System.Drawing.Point(545, 370);
    //        textBox2.Multiline = true;
    //        textBox2.Name = $"textBox2.";
    //        textBox2.Size = new System.Drawing.Size(300, 100);
    //        f.Controls.Add(textBox2);

    //        #endregion
    //        #endregion



    //        string firstStr = "";
    //        List<List<object>> listComplexObject = new List<List<object>>();

    //        button1.Click += delegate
    //        {
    //            firstStr = textBox2.Text;
    //            string[] array1 = Separated.FiltredTrash(firstStr);
    //            string[,] doubleMass = Separated.SeparatDot(array1);


    //            listComplexObject = CreateElements.Elements(doubleMass, f);
    //        };




    //        List<List<string>> listComplexString = new List<List<string>>();

    //        butSave.Click += delegate
    //        {
    //            listComplexString = CreateElements.ToStingFromTextBox(listComplexObject);


    //            List<string> list = listComplexString[1];
    //            textBox1.Text = string.Join(";", list);
    //        };
    //        Application.Run(f);
    //    }
    //}

    #endregion
    #region SaveDialog

    //Stream myStream;
    //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

    //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"  ;
    // saveFileDialog1.FilterIndex = 2 ;
    // saveFileDialog1.RestoreDirectory = true ;

    // if(saveFileDialog1.ShowDialog() == DialogResult.OK)
    // {
    //     if((myStream = saveFileDialog1.OpenFile()) != null)
    //     {
    //         // Code to write the stream goes here.
    //         myStream.Close();
    //     }
    // }


    //public void ChooseFolder()
    //{
    //    //Stream my;
    //    FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
    //    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
    //    {
    //        textBox1.Text = folderBrowserDialog1.SelectedPath;
    //        //my.Close();
    //    }
    //}


    #endregion
    #region Base#5

    /// <summary>
    /// Первична обработка SQL запроса.
    /// Разделяет его на 
    /// </summary>
    //public class Separated
    //{
    //    /// <summary>
    //    /// Получаем первичный массив с атрибутами, где алиасы еще не разделены
    //    /// </summary>
    //    /// <param name="str">Первичный запрос</param>
    //    /// <returns></returns>
    //    private static string[] FiltredTrash(string query)
    //    {
    //        string[] mas1 = query.Split(' ', ',', '\n');
    //        List<string> list = new List<string>();

    //        foreach (var item in mas1)
    //        {
    //            Regex regex = new Regex("[.]");
    //            bool match = regex.IsMatch(item);
    //            if (match)
    //                list.Add(item);
    //        }
    //        return list.ToArray();
    //    }
    //    /// <summary>
    //    /// Разделяет массив на двумерный. Алиас и имя поля.
    //    /// </summary>
    //    /// <param name="mas"></param>
    //    /// <returns></returns>

    //    public static string[] GetAlias(string query)
    //    {
    //        string[] firstSepar = FiltredTrash(query);

    //        string[] result = new string[firstSepar.Length];

    //        for (int i = 0; i < firstSepar.Length; i++)
    //        {
    //            int index = firstSepar[i].IndexOf('.');
    //            result[i] = firstSepar[i].Substring(0, firstSepar.Length - index + 1);
    //        }
    //        return result;
    //    }
    //    public static string[] GetFields(string query)
    //    {
    //        string[] firstSepar = FiltredTrash(query);

    //        string[] result = new string[firstSepar.Length];

    //        for (int i = 0; i < firstSepar.Length; i++)
    //        {
    //            int index = firstSepar[i].IndexOf('.');
    //            result[i] = firstSepar[i].Substring(index + 1);
    //        }
    //        return result;
    //    }
    //}
    //public class CreateElements
    //{
    //    public static List<object> Alias(string[] arrayAlias, Form f)
    //    {
    //        List<object> result = new List<object>();

    //        for (int i = 0, n = 75; i < arrayAlias.Length; i++, n += 25)
    //        {
    //            result.Add(new TextBox()
    //            {
    //                Location = new System.Drawing.Point(75, n),
    //                Name = $"Alias.{i}",
    //                Size = new System.Drawing.Size(100, 20),
    //                Text = arrayAlias[i]
    //            });
    //            f.Controls.Add(result[i] as TextBox);

    //        }
    //        return result;
    //    }
    //    public static List<object> Fields(string[] arrayFields, Form f)
    //    {
    //        List<object> result = new List<object>();
    //        for (int i = 0, n = 75; i < arrayFields.Length; i++, n += 25)
    //        {
    //            result.Add(new TextBox()
    //            {
    //                Location = new System.Drawing.Point(200, n),
    //                Name = $"Fields.{i}",
    //                Size = new System.Drawing.Size(100, 20),
    //                Text = arrayFields[i]
    //            });
    //            f.Controls.Add(result[i] as TextBox);
    //        }
    //        return result;
    //    }
    //    /// <summary>
    //    /// Создает элементы для типа данных
    //    /// </summary>
    //    /// <param name="anyArray">Либо Alias, либо Fiels. Важно только его длина</param>
    //    /// <param name="f"></param>
    //    /// <returns></returns>
    //    public static List<object> Type(string[] anyArray, Form f)
    //    {
    //        List<object> result = new List<object>();
    //        for (int i = 0, n = 75; i < anyArray.Length; i++, n += 25)
    //        {

    //            result.Add(new ComboBox()
    //            {
    //                DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList,
    //                Location = new System.Drawing.Point(340, n),
    //                Name = $"Type.{i}",
    //                Size = new System.Drawing.Size(120, 20),
    //            });

    //            (result[i] as ComboBox).Items.AddRange(new object[] { "string", "decimal", "date" });

    //            f.Controls.Add(result[i] as ComboBox);

    //        }
    //        return result;
    //    }

    //}
    //public class Convert
    //{
    //    /// <summary>
    //    /// Перевод из object в string
    //    /// </summary>
    //    /// <param name="listObjet"></param>
    //    /// <returns></returns>
    //    public static List<string> ToStingFromObject(List<object> listObjet)
    //    {
    //        List<string> result = new List<string>();

    //        for (int i = 0; i < listObjet.Count; i++)
    //        {
    //            if (listObjet[i] is TextBox)
    //                result.Add((listObjet[i] as TextBox).Text);
    //            else if (listObjet[i] is ComboBox)
    //                result.Add((listObjet[i] as ComboBox).Text);
    //        }
    //        return result;
    //    }
    //}

    //public class SaveTemplates
    //{
    //    public string ChooseFolder()
    //    {
    //        string result = String.Empty;

    //        FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
    //        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
    //        {
    //            result = folderBrowserDialog1.SelectedPath;
    //        }
    //        return result;
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        #region Initialization Form

    //        Form myForm = new Form();
    //        Button butInitalElements = new Button();
    //        Button butSave = new Button();
    //        // Button button3 = new Button();
    //        TextBox textBox1 = new TextBox();
    //        TextBox textBox2 = new TextBox();

    //        #region Designer

    //        myForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        myForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        myForm.ClientSize = new System.Drawing.Size(1031, 682);

    //        //Button 1 - Генерация элементов
    //        butInitalElements.Location = new System.Drawing.Point(921, 44);
    //        butInitalElements.Name = "butInitalElements";
    //        butInitalElements.Size = new System.Drawing.Size(75, 23);
    //        butInitalElements.Text = "butInitalElements";
    //        butInitalElements.UseVisualStyleBackColor = true;
    //        myForm.Controls.Add(butInitalElements);

    //        //Button 2 - Обработка измененной информации
    //        butSave.Location = new System.Drawing.Point(921, 146);
    //        butSave.Name = "butSave";
    //        butSave.Size = new System.Drawing.Size(75, 23);
    //        butSave.TabIndex = 1;
    //        butSave.Text = "butSave";
    //        butSave.UseVisualStyleBackColor = true;
    //        myForm.Controls.Add(butSave);

    //        ////Button 3 - Обработка измененной информации
    //        //button3.Location = new System.Drawing.Point(921, 251);
    //        //button3.Name = "button3";
    //        //button3.Size = new System.Drawing.Size(75, 23);
    //        //button3.TabIndex = 1;
    //        //button3.Text = "button3";
    //        //button3.UseVisualStyleBackColor = true;
    //        //myForm.Controls.Add(button3);

    //        // Ввод SQL запроса
    //        textBox1.Location = new System.Drawing.Point(12, 12);
    //        textBox1.Name = $"textBox1.";
    //        textBox1.Size = new System.Drawing.Size(284, 387);
    //        myForm.Controls.Add(textBox1);
    //        textBox1.Multiline = true;


    //        //textBox2.Location = new System.Drawing.Point(545, 370);
    //        //textBox2.Name = $"textBox2.";
    //        //textBox2.Size = new System.Drawing.Size(300, 100);
    //        //myForm.Controls.Add(textBox2);

    //        #endregion
    //        #endregion

    //        #region Данные

    //        List<object> listAliasObject = new List<object>();
    //        List<object> listFieldsObject = new List<object>();
    //        List<object> listTypeObject = new List<object>();

    //        List<string> listAliasString = new List<string>();
    //        List<string> listFeildsString = new List<string>();
    //        List<string> listTypeString = new List<string>();

    //        #endregion

    //        butInitalElements.Click += delegate
    //        {
    //            string[] alias = Separated.GetAlias(textBox1.Text);
    //            string[] fields = Separated.GetFields(textBox1.Text);

    //            listAliasObject = CreateElements.Alias(alias, myForm);
    //            listFieldsObject = CreateElements.Fields(fields, myForm);
    //            listTypeObject = CreateElements.Type(alias, myForm);
    //        };

    //        butSave.Click += delegate
    //        {
    //            listAliasString = Convert.ToStingFromObject(listAliasObject);
    //            listFeildsString = Convert.ToStingFromObject(listFieldsObject);
    //            listTypeString = Convert.ToStingFromObject(listTypeObject);
    //        };
    //        Application.Run(myForm);
    //    }
    //}
    #endregion
    #region Base#6


    //    #region Working
    //    /// <summary>
    //    /// Получение массива элементов (Алиас или поле)
    //    /// </summary>
    //    public class Separated
    //    {
    //        /// <summary>
    //        /// Создаем массив слов, в которых есть точка.
    //        /// </summary>
    //        /// <param name="str">Первичный запрос</param>
    //        /// <returns></returns>
    //        private static string[] FiltredTrash(string query)
    //        {

    //            string[] mas1 = query.Split(' ', ',', '\r', '\n');
    //            List<string> list = new List<string>();

    //            foreach (var item in mas1)
    //            {
    //                Regex regex = new Regex("[.]");
    //                bool match = regex.IsMatch(item);
    //                if (match)
    //                    list.Add(item.ToLower());
    //            }
    //            return list.ToArray();
    //        }
    //        /// <summary>
    //        /// Получаем с общего запроса массив алиасов
    //        /// </summary>
    //        /// <param name="mas"></param>
    //        /// <returns></returns>
    //        public static string[] GetAlias(string query)
    //        {
    //            string[] firstSepar = FiltredTrash(query);

    //            string[] result = new string[firstSepar.Length];

    //            for (int i = 0; i < firstSepar.Length; i++)
    //            {
    //                int index = firstSepar[i].IndexOf('.');
    //                result[i] = firstSepar[i].Substring(0, index);
    //            }
    //            return result;
    //        }
    //        /// <summary>
    //        /// Получаем массив полей
    //        /// </summary>
    //        /// <param name="query"></param>
    //        /// <returns></returns>
    //        public static string[] GetFields(string query)
    //        {
    //            string[] firstSepar = FiltredTrash(query);

    //            string[] result = new string[firstSepar.Length];

    //            for (int i = 0; i < firstSepar.Length; i++)
    //            {
    //                int index = firstSepar[i].IndexOf('.');
    //                result[i] = firstSepar[i].Substring(index + 1);
    //            }
    //            return result;
    //        }
    //    }
    //    /// <summary>
    //    /// Добавление элементов в форме. Возращает list<object>
    //    /// </summary>
    //    public class CreateElements
    //    {

    //        /// <summary>
    //        /// Создание TextBox для Алиасов. 
    //        /// </summary>
    //        /// <param name="arrayAlias"></param>
    //        /// <param name="f"></param>
    //        /// <returns>Лист с объектами</returns>
    //        public static List<object> Alias(string[] arrayAlias, Form f)
    //        {
    //            List<object> result = new List<object>();

    //            for (int i = 0, n = 44; i < arrayAlias.Length; i++, n += 25)
    //            {
    //                result.Add(new TextBox()
    //                {
    //                    Location = new System.Drawing.Point(319, n),
    //                    Name = $"Alias.{i}",
    //                    Size = new System.Drawing.Size(100, 20),
    //                    Text = arrayAlias[i]
    //                });
    //                f.Controls.Add(result[i] as TextBox);

    //            }
    //            return result;
    //        }
    //        /// <summary>
    //        /// TextBox for Fields. List object 
    //        /// </summary>
    //        /// <param name="arrayFields"></param>
    //        /// <param name="f"></param>
    //        /// <returns></returns>
    //        public static List<object> Fields(string[] arrayFields, Form f)
    //        {
    //            List<object> result = new List<object>();
    //            for (int i = 0, n = 44; i < arrayFields.Length; i++, n += 25)
    //            {
    //                result.Add(new TextBox()
    //                {
    //                    Location = new System.Drawing.Point(441, n),
    //                    Name = $"Fields.{i}",
    //                    Size = new System.Drawing.Size(122, 20),
    //                    Text = arrayFields[i]
    //                });
    //                f.Controls.Add(result[i] as TextBox);
    //            }
    //            return result;
    //        }
    //        /// <summary>
    //        /// ComboBox for Type. return List object
    //        /// </summary>
    //        /// <param name="anyArray"></param>
    //        /// <param name="f"></param>
    //        /// <returns></returns>
    //        public static List<object> Type(string[] anyArray, Form f)
    //        {
    //            List<object> result = new List<object>();
    //            for (int i = 0, n = 44; i < anyArray.Length; i++, n += 25)
    //            {

    //                result.Add(new ComboBox()
    //                {
    //                    DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList,
    //                    Location = new System.Drawing.Point(588, n),
    //                    Name = $"Type.{i}",
    //                    Size = new System.Drawing.Size(120, 20),
    //                });

    //                (result[i] as ComboBox).Items.AddRange(new object[] { "string", "decimal", "date" });

    //                f.Controls.Add(result[i] as ComboBox);

    //            }
    //            return result;
    //        }

    //    }
    //    /// <summary>
    //    /// Downcast. Get object.Text in List string
    //    /// </summary>
    //    public class Convert
    //    {
    //        /// <summary>
    //        /// For TextBox or ComboBox
    //        /// </summary>
    //        /// <param name="listObjet"></param>
    //        /// <returns></returns>
    //        public static List<string> ToStingFromObject(List<object> listObjet)
    //        {
    //            List<string> result = new List<string>();

    //            for (int i = 0; i < listObjet.Count; i++)
    //            {
    //                if (listObjet[i] is TextBox)
    //                    result.Add((listObjet[i] as TextBox).Text);
    //                else if (listObjet[i] is ComboBox)
    //                    result.Add((listObjet[i] as ComboBox).Text);
    //            }
    //            return result;
    //        }
    //    }

    //    /// <summary>
    //    /// Выбор 
    //    /// </summary>
    //    public class Select
    //    {
    //        /// <summary>
    //        /// Выбор папки для сохранения
    //        /// </summary>
    //        /// <param name="path"></param>
    //        /// <returns></returns>
    //        public static string ChooseFolder(string path)
    //        {
    //            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
    //            folderBrowserDialog1.SelectedPath = path;
    //            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
    //            {
    //                path = folderBrowserDialog1.SelectedPath;
    //            }
    //            return path;
    //        }
    //    }
    //    public class SaveTemplates
    //    {
    //        private static string FormationColumns(string nameTemp, List<string> listAlias, List<string> listFields, List<string> listType)
    //        {

    //            #region Вверхняя часть шаблона
    //            string upText = $@"<?xml version=""1.0"" encoding=""utf-8"" ?>
    //<QueryTemplateContainer xmlns=""http://CommonComponents/Templates/QueryTemplate.xsd""
    //                        name=""{nameTemp}""
    //                        version=""""
    //                        dalProvider=""Oracle""
    //                        dalModule=""RvcVio.ThesAccess.Oracle.Dal""
    //                        dalScheme=""empty""
    //                        dalObject=""empty"">
    //  <Description xmlns=""http://CommonComponents/Templates/Templates.xsd"">
    //    Navigator test
    //  </Description>
    //  <!--Опционально Permissions - Разрешения-->
    //  <!--<Permissions xmlns=""http://CommonComponents/Templates/Templates.xsd"">
    //    <Permission type=""O""
    //      name=""AdmNar.O_AdmNar_VK""
    //    	access=""allow""/>
    //  </Permissions>-->
    //  <Query name=""{nameTemp}""
    //  			 defaultSelect=""select0"">
    //    <!--Опцианальны Parameters-->
    //    <!--<Parameters>
    //      <Parameter name=""code_no"" type=""string""/>
    //      <Parameter name=""datefrom"" type=""datetime"" />
    //      <Parameter name=""dateto"" type=""datetime"" />
    //    </Parameters>-->
    //    <Select name=""select0"">
    //      <!--Опцианально SqlParameter-->
    //      <!--<SqlParameter name=""code_no"" oraDbType=""varchar2"" type=""string""/>
    //      <SqlParameter name=""datefrom"" oraDbType=""date"" type=""datetime"" />
    //      <SqlParameter name=""dateto"" oraDbType=""date"" type=""datetime"" />-->
    //";
    //            #endregion
    //            #region Нижняя часть шаблона
    //            string downText = $@"      <!--From и Join нужно доделать-->
    //      <From>
    //        <!--<Table scheme=""VIO$INF"" name=""rfn_doc"" alias=""d""/>-->
    //      </From>
    //      <Join mode=""LEFT"">
    //        <!--<Table scheme=""VIO$INF"" name=""R$RFN_DOC"" alias=""rd"" />
    //        <On>d.doc_type = rd.id</On>-->
    //      </Join>
    //      <!--Опционально-->
    //      <!--<Where>
    //        <Expression>
    //          (dvk.CODE_NO=:code_no OR '9965'=:code_no OR '0000'=:code_no OR '9961'=:code_no OR
    //          dvk.CODE_NO IN  (SELECT KOD
    //          FROM MDM_LOCAL.THES_SOUN SOUN
    //          WHERE SOUN.KODV = :code_no AND
    //          SOUN.IS_CLOSED = 0 AND SOUN.IS_ANNULED = 0 AND SOUN.TRS_CANCEL_ID IS NULL AND SYSDATE BETWEEN DATE_FROM AND DATE_TO
    //          )
    //          )
    //          and (d.doc_date between :datefrom and :dateto or d.doc_date is null)
    //          and (ds.status_doc = 30)
    //        </Expression>
    //      </Where>-->
    //      <!--Опционально-->
    //      <!--Order>
    //        <Item>
    //          <Field table=""d""  column=""doc_date"" />
    //        </Item>
    //      </Order>-->
    //    </Select>
    //  </Query>
    //</QueryTemplateContainer>";
    //            #endregion


    //            string columns = String.Empty;
    //            for (int i = 0; i < listAlias.Count(); i++)
    //            {
    //                switch (listType[i])
    //                {
    //                    case "string":
    //                    case "decimal":
    //                        columns += $"<Column name=\"{listFields[i]}\" type=\"{listType[i]}\" column=\"{listFields[i]}\" table=\"{listAlias[i]}\"/>\n";
    //                        break;
    //                    case "date":
    //                        columns += $"<Column name=\"{listFields[i]}\" type=\"{listType[i]}\" column=\"{listFields[i]}\" table=\"{listAlias[i]}\" options=\"DataSetDateTime.Unspecified\"/>\n";
    //                        break;
    //                    default:
    //                        break;
    //                }
    //            }
    //            return $"{upText}\n<Columns>\n{columns}\n</Columns>\n{downText}";
    //        }
    //        public static void SaveFiles(string path, string name, List<string> listAlias, List<string> listFields, List<string> listType)
    //        {
    //            string fullName = $"{path}/{name}.txt";

    //            string text = FormationColumns(name, listAlias, listFields, listType);

    //            using (FileStream file = new FileStream(fullName, FileMode.Create))
    //            {
    //                using (StreamWriter stream = new StreamWriter(file))
    //                {
    //                    stream.WriteLine(text);
    //                }
    //            }

    //        }
    //    }
    //    public class Check
    //    {
    //        public static bool ForType(List<string> list)
    //        {
    //            bool result = true;
    //            foreach (var item in list)
    //            {
    //                if (item.Length == 0)
    //                    result = false;
    //            }
    //            return result;
    //        }
    //    }
    //    class Program
    //    {
    //        [STAThread]
    //        static void Main()
    //        {
    //            #region Initialization Form

    //            Form myForm = new Form();


    //            Button butInitalElements = new Button();
    //            Button butSave = new Button();

    //            Button butSelectPath = new Button();

    //            TextBox textBoxSQL = new TextBox();
    //            TextBox textBoxNameTemp = new TextBox();
    //            TextBox textBoxPath = new TextBox();

    //            //For elements
    //            Label labelAlias = new Label();
    //            Label labelField = new Label();
    //            Label labelType = new Label();

    //            //Other
    //            Label labelSqlInput = new Label();
    //            Label labelPath = new Label();
    //            Label labelNameTemp = new Label();

    //            #region Designer

    //            // myForm
    //            myForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //            myForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //            myForm.ClientSize = new System.Drawing.Size(1031, 682);
    //            myForm.BackColor = System.Drawing.Color.Lavender;

    //            #region Button
    //            //butInitalElements - Генерация элементов
    //            butInitalElements.Location = new System.Drawing.Point(921, 44);
    //            butInitalElements.Size = new System.Drawing.Size(75, 23);
    //            butInitalElements.Text = "Generate";
    //            myForm.Controls.Add(butInitalElements);

    //            //butSave - Обработка измененной информации и сохранение
    //            butSave.Location = new System.Drawing.Point(921, 146);
    //            butSave.Size = new System.Drawing.Size(75, 23);
    //            butSave.Text = "Save";
    //            myForm.Controls.Add(butSave);

    //            //butSelectPath - Выбрать путь
    //            butSelectPath.Location = new System.Drawing.Point(221, 626);
    //            butSelectPath.Size = new System.Drawing.Size(75, 23);
    //            butSelectPath.Text = "Select";
    //            myForm.Controls.Add(butSelectPath);
    //            #endregion
    //            #region TextBox

    //            //textBoxSQL - ввод SQL запроса
    //            textBoxSQL.Location = new System.Drawing.Point(12, 42);
    //            textBoxSQL.Name = $"textBoxSQL.";
    //            textBoxSQL.Size = new System.Drawing.Size(284, 387);
    //            textBoxSQL.Multiline = true;
    //            myForm.Controls.Add(textBoxSQL);

    //            //textBoxPath - ввод поля
    //            textBoxPath.Location = new System.Drawing.Point(12, 562);
    //            textBoxPath.Name = "textBoxPath";
    //            textBoxPath.Multiline = true;
    //            textBoxPath.Size = new System.Drawing.Size(284, 58);
    //            textBoxPath.Text = @"C:\Users\Пользователь\Desktop\Query";
    //            myForm.Controls.Add(textBoxPath);

    //            //textBoxNameTemp - ввод имя шаблона
    //            textBoxNameTemp.Location = new System.Drawing.Point(12, 488);
    //            textBoxNameTemp.Name = "textBoxNameTemp";
    //            textBoxNameTemp.Size = new System.Drawing.Size(284, 20);
    //            textBoxNameTemp.Text = "test";
    //            myForm.Controls.Add(textBoxNameTemp);
    //            #endregion
    //            #region Label

    //            #region For elements
    //            // Label Alias
    //            labelAlias.AutoSize = true;
    //            labelAlias.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //            labelAlias.Location = new System.Drawing.Point(327, 13);
    //            labelAlias.Size = new System.Drawing.Size(60, 20);
    //            labelAlias.Text = "Алиас";
    //            myForm.Controls.Add(labelAlias);

    //            // Label Field
    //            labelField.AutoSize = true;
    //            labelField.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //            labelField.Location = new System.Drawing.Point(455, 13);
    //            labelField.Size = new System.Drawing.Size(90, 20);
    //            labelField.Text = "Имя поля";
    //            myForm.Controls.Add(labelField);

    //            // Label Type
    //            labelType.AutoSize = true;
    //            labelType.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //            labelType.Location = new System.Drawing.Point(590, 13);
    //            labelType.Size = new System.Drawing.Size(110, 20);
    //            labelType.Text = "Тип данных";
    //            myForm.Controls.Add(labelType);

    //            #endregion
    //            #region Other

    //            // Label SqlInput
    //            labelSqlInput.AutoSize = true;
    //            labelSqlInput.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //            labelSqlInput.Location = new System.Drawing.Point(12, 18);
    //            labelSqlInput.Size = new System.Drawing.Size(105, 21);
    //            labelSqlInput.Text = "SQL запрос";
    //            myForm.Controls.Add(labelSqlInput);

    //            // Label Path
    //            labelPath.AutoSize = true;
    //            labelPath.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //            labelPath.Location = new System.Drawing.Point(12, 538);
    //            labelPath.Size = new System.Drawing.Size(165, 21);
    //            labelPath.Text = "Адрес сохранения";
    //            myForm.Controls.Add(labelPath);

    //            // Label NameTemp
    //            labelNameTemp.AutoSize = true;
    //            labelNameTemp.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //            labelNameTemp.Location = new System.Drawing.Point(12, 464);
    //            labelNameTemp.Size = new System.Drawing.Size(124, 21);
    //            labelNameTemp.Text = "Имя шаблона";
    //            myForm.Controls.Add(labelNameTemp);

    //            #endregion
    //            #endregion
    //            #endregion
    //            #endregion

    //            #region Данные

    //            List<object> listAliasObject = new List<object>();
    //            List<object> listFieldsObject = new List<object>();
    //            List<object> listTypeObject = new List<object>();

    //            List<string> listAliasString = new List<string>();
    //            List<string> listFeildsString = new List<string>();
    //            List<string> listTypeString = new List<string>();

    //            #endregion

    //            #region Button.Click

    //            butInitalElements.Click += delegate
    //            {
    //                string[] alias = Separated.GetAlias(textBoxSQL.Text);
    //                string[] fields = Separated.GetFields(textBoxSQL.Text);

    //                listAliasObject = CreateElements.Alias(alias, myForm);
    //                listFieldsObject = CreateElements.Fields(fields, myForm);
    //                listTypeObject = CreateElements.Type(alias, myForm);
    //            };

    //            butSave.Click += delegate
    //            {
    //                listAliasString = Convert.ToStingFromObject(listAliasObject);
    //                listFeildsString = Convert.ToStingFromObject(listFieldsObject);
    //                listTypeString = Convert.ToStingFromObject(listTypeObject);

    //                if (textBoxPath.Text == String.Empty || textBoxNameTemp.Text == String.Empty)
    //                    MessageBox.Show("Не указан адрес или имя для сохранения", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //                else if (!Check.ForType(listTypeString))
    //                    MessageBox.Show("Укажите тип данных", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //                else
    //                {
    //                    SaveTemplates.SaveFiles(textBoxPath.Text, textBoxNameTemp.Text, listAliasString, listFeildsString, listTypeString);
    //                    DialogResult result = MessageBox.Show("Файл сохранен!\nОткрыть файл?", "Сохранение", MessageBoxButtons.YesNo);
    //                    if (result == DialogResult.Yes)
    //                    {
    //                        Process.Start("notepad.exe", $"{textBoxPath.Text}/{textBoxNameTemp.Text}.txt");
    //                    }
    //                }
    //            };

    //            butSelectPath.Click += delegate
    //            {
    //                textBoxPath.Text = Select.ChooseFolder(textBoxPath.Text);
    //            };
    //            #endregion

    //            Application.Run(myForm);
    //        }
    //    }
    //    #endregion
    #endregion
    #endregion

}
