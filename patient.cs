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
        private int National_Code = 0;
        public int national_code
        {
            get
            {
                return this.National_Code;

            }
            set
            {
                if (value < 0)
                    this.National_Code = -1 * value;
                else
                    this.National_Code = value;
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

        public void information_patient()
        {
            Console.WriteLine("fisrt name: {0} ,last name: {1}, National Code: {2},sickness: {3}, doctor: {4}, room number{5}", firstname, lastname, National_Code, sickness, doctor,room_number);
        }

    }
}
