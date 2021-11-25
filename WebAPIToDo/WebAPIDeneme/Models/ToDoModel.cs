using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDeneme.Models
{
    public class ToDoModel
    {
        public int ToDoId { get; set; }
        public DateTime Date { get; set; }
        public string ToDo { get; set; }
        public bool IsToDo { get; set; }
    }
}
