using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_1_hospital_managment_
{
    public class Patient
    {
        public string firstname= "";
        public string lastname= "";
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
        public string sickness { get; set; }
        public string doctor { get; set; }
        private int room_number;
        public int Room_number { get
            {
                return this.room_number;
            }
            
            set
            { 
                if(value < 0)
                    this.room_number = -1 * this.room_number;
            } }
        //public void info(string first, string last,int id,string sick,string doctor,int room)
        //{
        //    this.firstname = first;
        //    this.lastname = last;
        //    this.id = id;
        //    this.sickness = sick;
        //    this.doctor = doctor;
        //    this.room_number = room;
        //}
        public string fullName()
        {
            return this.firstname + this.lastname;
        }
            
    }
}
