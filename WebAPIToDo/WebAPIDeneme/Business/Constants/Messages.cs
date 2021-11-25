using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDeneme.Business.Constants
{
    public static class Messages
    {
        public static string SuccessGetListAllToDo = "Yapılacak tüm görevler başarıyla getirildi.";
        public static string ErrorGetListAllToDo = "Yapılacak tüm görevler getirilirken bir sorun oluştu!";

        public static string SuccessGetListCompletedToDo = "Tamamlanmış olan görevler başarıyla getirildi.";
        public static string ErrorGetListCompletedToDo = "Tamamlanmış olan görevler getirilirken bir sorun oluştu!";

        public static string SuccessGetListUncompletedToDo = "Tamamlanmamış olan görevler başarıyla getirildi.";
        public static string ErrorGetListUncompletedToDo = "Tamamlanmamış olan görevler getirilirken bir sorun oluştu!";

        public static string SuccessGetToDo = "Görev başarıyla getirildi.";
        public static string ErrorGetToDo = "Görev getirilirken bir sorun oluştu!";

        public static string ErrorUpdateToDo = "Görev güncellemesi başarısız oldu!";

        public static string ErrorAddToDo = "Görev ekleme başarısız oldu!";
    }
}
