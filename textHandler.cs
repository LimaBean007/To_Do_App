using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace To_Do_App
{
    class textHandler
    {
        private string taskName;
        private string desc;
        private string prio;

        public textHandler(string taskName, string desc, string prio)
        {
            this.taskName = taskName;
            this.desc = desc;
            this.prio = prio;
        }

        public void writeToFile()
        {

            try
            {
                StreamWriter addTask = new StreamWriter("toDoList.txt", true);
                DateTime now = DateTime.Now;
                string line = taskName + "#" + desc + "#" + prio + "#" + now.ToString();
                addTask.WriteLine(line);
                addTask.Close();
                MessageBox.Show("Task successfully added");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}

      
