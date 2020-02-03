using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone_2_Task_List
{
    class Do
    {
        private string name;
        private string task;
        private string due;
        private string description;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Task
        {
            get { return task; }
            set { task = value; }
        }

        public string Due
        {
            get { return due; }
            set { due = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Do()
        {

        }

        public Do(string _name, string _task, string _due, string _description)
        {
            name = _name;
            task = _task;
            due = _due;
            description = _description;
        }

        public static void PrintTaskList(List<string> list1, List<string> list2)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"{");
            }
        }
        

    }
}
