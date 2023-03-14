using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_1_hospital_managment_
{
    public class Nurse
    {

        public string firstname { get; set; }
        public string lastname { get; set; }
        private int id = 0;
        public int Id
        {
            get
            {
                return this.id;

            }
            set
            {
                if (value < 0)
                    this.id = -1 * value;
                else
                    this.id = value;
            }
        }
        public Nurse(string firstname, string lastname, int id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.id = id;
        }
    }
}
