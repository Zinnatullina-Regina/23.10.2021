using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vassal_moego_vassala_ne_moi_vassal
{

    class Worker
    {

        private string name;
        private int status;
        private string specialist;
        private string havingtask;
        public string Havingtask
        {
            get { return havingtask; }
            set {  }
        }
        public string Name
        {
            get { return name; }
        }
        public int Statu
        {
            get { return status; }
        }

        public string Specialist
        {
            get { return specialist; }
        }
        public Worker(string name, string specialist, int status, string havingtask)
        {
            this.havingtask = havingtask;
            this.specialist = specialist;
            this.name = name;
            this.status = status;
        }


    }
    
}
