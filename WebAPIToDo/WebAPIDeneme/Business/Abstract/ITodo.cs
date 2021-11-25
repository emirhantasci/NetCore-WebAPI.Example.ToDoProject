using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDeneme.Models;

namespace WebAPIDeneme.Business.Abstract
{
    public interface ITodo
    {
        ResultsModel GetListAllToDo();
        ResultsModel GetListCompletedToDo();
        ResultsModel GetListUncompletedToDo();
        ResultModel GetToDo(int id);
        string AddNewTodo(ToDoModel toDoModel);
        string UpdateToDo(ToDoModel toDoModel);

    }
}
