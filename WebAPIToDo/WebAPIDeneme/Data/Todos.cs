using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDeneme.Models;

namespace WebAPIDeneme.Data
{
    public class Todos
    {
        public static List<ToDoModel> toDos = null;

        static Todos()
        {
            toDos = new List<ToDoModel>()
            {
                new ToDoModel()
                {
                    ToDoId=1,
                    Date= Convert.ToDateTime("25.11.2021"),
                    ToDo="Yapılacak iş 1",
                    IsToDo=false
                },
                new ToDoModel()
                {
                    ToDoId=2,
                    Date= Convert.ToDateTime("25.11.2021"),
                    ToDo="Yapılacak iş 2",
                    IsToDo=true
                }
            };
            
        }
    }
}
