using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace To_Do_App
{
    class ReadTextHandler
    {
        public void readFromFile()
        {
            try
            {
                using (StreamReader newReader = new StreamReader("toDoList.txt"))
                {
                    string line;
                    while ((line = newReader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('#');
                        string taskName = parts[0];
                        string desc = parts[1];
                        string prio = parts[2];

                        string[] fullDate = parts[3].Split('/');
                        int year = Convert.ToInt32(fullDate[0]);
                        int month = Convert.ToInt32(fullDate[1]);
                        int day = Convert.ToInt32(fullDate[2]);
                        DateTime newDate = new DateTime(year, month, day);

                        toDoItems newToDo = new toDoItems(taskName, desc, prio, newDate);
                        listHandler.newItem.Add(newToDo);

                    }

                }


            }
            catch (Exception e)
            { MessageBox.Show(e.ToString()); }
        }
    }
}

