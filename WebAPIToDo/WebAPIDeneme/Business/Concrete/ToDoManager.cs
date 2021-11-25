using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDeneme.Business.Abstract;
using WebAPIDeneme.Business.Constants;
using WebAPIDeneme.Data;
using WebAPIDeneme.Models;

namespace WebAPIDeneme.Business.Concrete
{
    public class ToDoManager : ITodo
    {
        public string AddNewTodo(ToDoModel toDoModel)
        {
            Todos.toDos.Add(toDoModel);
            ToDoModel addToDo = Todos.toDos.Where(id => id.ToDoId == toDoModel.ToDoId).FirstOrDefault();
            if (addToDo.ToDoId==toDoModel.ToDoId)
            {
                return "Başarılı";
            }
            else
            {
                return (Messages.ErrorAddToDo);
            }
        }


        public ResultsModel GetListAllToDo()
        {
            List<ToDoModel> getList = Todos.toDos;
            ResultsModel result = new ResultsModel();
            result.ToDos = getList;
            if (getList.Count > 0)
            {
                result.Message = "Başarılı";
                return result;
            }
            else
            {
                result.Message = Messages.ErrorGetListAllToDo;
                return result;
            }
        }

        public ResultsModel GetListCompletedToDo()
        {
            List<ToDoModel> completedToDos = Todos.toDos.Where(ct => ct.IsToDo == true).ToList();
            ResultsModel result = new ResultsModel();
            result.ToDos = completedToDos;
            if (completedToDos.Count>0)
            {
                result.Message = "Başarılı";
                return result;
            }
            else
            {
                result.Message = Messages.ErrorGetListCompletedToDo;
                return result;
            }
        }

        public ResultsModel GetListUncompletedToDo()
        {
            List<ToDoModel> uncompletedTodos = Todos.toDos.Where(ct => ct.IsToDo == false).ToList();
            ResultsModel result = new ResultsModel();
            result.ToDos = uncompletedTodos;
            if (uncompletedTodos.Count>0)
            {
                result.Message = "Başarılı";
                return result;
            }
            else
            {
                result.Message = Messages.ErrorGetListUncompletedToDo;
                return result;
            }
        }

        public ResultModel GetToDo(int id)
        {
            ToDoModel getIdToDo = Todos.toDos.Where(no => no.ToDoId == id).FirstOrDefault();
            ResultModel result = new ResultModel();
            result.ToDo = getIdToDo;
            
            if (getIdToDo!=null)
            {
                result.Message = "Başarılı";
                return result;
            }
            else
            {
                result.Message = Messages.ErrorGetToDo;
                return result;
            }
            
        }

        public string UpdateToDo(ToDoModel toDoModel)
        {
            ToDoModel savedTodo = Todos.toDos.Where(id => id.ToDoId == toDoModel.ToDoId).FirstOrDefault();
            Todos.toDos.Remove(savedTodo);
            Todos.toDos.Add(toDoModel);

            ToDoModel ifToDo = Todos.toDos.Where(id => id.ToDoId == savedTodo.ToDoId).FirstOrDefault();
            if (ifToDo.Date==toDoModel.Date && ifToDo.IsToDo==toDoModel.IsToDo && ifToDo.ToDo==toDoModel.ToDo && ifToDo.ToDoId==toDoModel.ToDoId)
            {
                return "Başarılı";
            }
            else
            {
                return Messages.ErrorUpdateToDo;
            }
            
        }
    }
}
