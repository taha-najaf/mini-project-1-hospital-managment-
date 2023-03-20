using System;
using System.Collections.Generic;
using System.Globalization;
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
        public void information_nurses()
        {
            Console.WriteLine("fisrt name: {0} ,last name: {1}, National_Code: {2}", firstname, lastname, id);
        }
        // treat nurse
        public static void treat (Patient[] patients )
        {
            for(int  i = 0; i < patients.Length; i++)
            {
                if (patients != null && patients[i] != null)
                {
                    Console.WriteLine("Enter National code : ");
                    int id = int.Parse(Console.ReadLine());
                    if (id != patients[i].national_code)
                        Console.WriteLine("The patient was not in the list");

                    else
                    {
                        patients[i].Room_number += " was treated!!! ";
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Patient was treated successfully !");
                        Console.BackgroundColor= ConsoleColor.Black;
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
