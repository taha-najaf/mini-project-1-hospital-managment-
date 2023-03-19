using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_1_hospital_managment_
{
    internal class Doctor
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        private int id = 0;
        public  int Id  
        {
            get
            { 
                return this.id;

            }
            set
            { 
                if(value<0)
                    this.id = -1*value;
                else
                    this.id = value;
            }
        }
        public string speciality { get; set; }
        public int record = 0;
        public Doctor (string firstname, string lastname, int id,string speciality ,int record)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.id = id; 
            this.speciality = speciality;
            this.record = record;
        }
        public void information_doctors ()
        {
            Console.WriteLine ("fisrt name: {0} ,last name: {1}, National_Code: {2},speciality: {3}, record: {4}",firstname,lastname,id,speciality,record);
        }
        public static void visit(int id, Patient[] patients)
        {
            for (int i = 0; i < patients.Length; i++)
            {
                if (patients != null && patients[i] != null)
                {
                    if (id != patients[i].national_code)
                        Console.WriteLine("The patient was not in the list");

                    else
                    {
                        patients[i].Room_number += " was visited! ";
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Patient was visited successfully !");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is no patient in hospital!");
                    Console.BackgroundColor = ConsoleColor.Black;

                    break;
                }
            }
        }
       
    }
}
