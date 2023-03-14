using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_1_hospital_managment_
{
    internal class Admin
    {
        public string username { get; set; }
        private long password = 0;
        public long Password
        {
            get
            {

                return this.password;
            }
            set
            { 
                if (value<0)
                    this.password = -1*(value);
                else
                    this.password = value;
            }
        }
        
    }
}
