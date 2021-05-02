using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do_App
{
    class toDoItems
    {
        private string taskName;
        private string taskDesc;
        private string priority;
        private DateTime newDate;

        public toDoItems(string taskName, string taskDesc, string priority, DateTime date)
        {
            this.taskName = taskName;
            this.taskDesc = taskDesc;
            this.priority = priority;
            this.newDate = date;
        }

        public string TaskName { get => taskName; set => taskName = value; }
        public string TaskDesc { get => taskDesc; set => taskDesc = value; }
        public string Priority { get => priority; set => priority = value; }
    }
}
