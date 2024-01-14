using System;

namespace homework5
{

    public static class Actions
    {
        public static Result InfoAction()
        {
            Result result = new Result();
            result.Status = "Info";
            result.Messege = "Все хорошо";
            result.DateTime = DateTime.Now;
            return result;
        }

        public static Result WarningAction()
        {
            Result result = new Result();
            result.Status = "Warning";
            result.Messege = "Что-то может пойти не так";
            result.DateTime = DateTime.Now;
            return result;
        }

        public static Result ErrorAction()
        {
            Result result = new Result();
            result.Status = "Error";
            result.Messege = "Что-то пошло не так";
            result.DateTime = DateTime.Now;
            return result;
        }
    }
}