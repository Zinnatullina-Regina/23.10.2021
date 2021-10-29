using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vassal_moego_vassala_ne_moi_vassal
{

    class Task
    {
        private string nameTask;
        private string name;
        private string otdels;
        private int statusTask;
        public string NameTask
        {
            get { return nameTask; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Otdels
        {
            get { return otdels; }
        }
        public int StatuTasks
        {
            get { return statusTask; }
        }
        public Task(string nameTask, string name, string otdels, int statusTask)
        {
            this.nameTask = nameTask;
            this.otdels = otdels;
            this.name = name;
            this.statusTask = statusTask;
        }


    }

}
