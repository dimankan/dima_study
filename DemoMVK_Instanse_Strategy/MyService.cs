using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVK_Instanse_Strategy
{
    public class MyService
    {
        public MyResponce DoRequest(MyRequest req)
        {
            var instance = GetInstance(req.TaskId);
            if (instance == null)
                return null;

            switch (req.RequestId)
            {
                case 1: // Get
                    return GetDocument();
                    break;
                case 2: // ChangeStatus
                    return ChangeStatus(instance, req.Id);
                    break;
            }
        }


        private TaskPatternBase GetInstance(decimal taskId)
        {
            switch (taskId)
            {
                case 1:
                    return new MyFirstTask();
                    break;
                case 2:
                    return new MySecondTask();
                    break;
            }
            return null;
        }
        private MyResponce GetDocument()
        {
            return new MyResponce();
        }
        private MyResponce ChangeStatus(TaskPatternBase instance, decimal id)
        {
            using (var context = new MyContext())
            {
                // Делаю свои действия
                // Вызов задачи
                try
                {
                    instance.SetStatus(context, id);
                    // Делаю свои действия
                    context.AcceptChanges();

                }
                catch (Exception ex)
                {
                    //Залогировали
                    // Откатил-
                    context.RollbackChanges();
                }
            }
        }
    }
}
