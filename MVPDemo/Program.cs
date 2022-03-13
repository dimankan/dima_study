using MVPDemo.Model;
using MVPDemo.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPDemo
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // model
            DemoModel model = new DemoModel();

            // view 
            DemoView view = new DemoView();

            // presenter
            DemoPresenter presenter = new DemoPresenter(model, view);

            //Application.Run(new DemoView());
            Application.Run(view);
        }
    }
}
