using MVPDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.Presenter
{
    public class DemoPresenter
    {
        private DemoModel _model;
        private DemoView _view;

        public DemoPresenter(DemoModel model, DemoView view)
        {
            this._model = model;
            this._view = view;

            view.Presenter = this;
        }

        public void OnOperand1Changed(int operand1)
        {
            _model.Operand1 = operand1;
        } 
        public void OnOperand2Changed(int operand1)
        {
            _model.Operand2 = operand1;
        }
        public void OnSumClicked()
        {
            _model.Sum();

            UpdateView();
        }

        private void UpdateView()
        {
            _view.UpdateView(_model.Operand1, _model.Operand2, _model.Result);
        }
    }
}
