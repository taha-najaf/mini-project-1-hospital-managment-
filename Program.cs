using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_1_hospital_managment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patient_count = 0, nurse_count = 0, doctor_count = 0;
            //============================ base menu
            while (true)
            {
                Console.WriteLine("choose one :");
                Console.WriteLine("Admin(a)\nDoctor(d)\nNurse(n)");
                //===============================  admin menu
                string choose = Console.ReadLine();
                if (choose == "a")
                {
                    Admin admin = new Admin();
                    Console.WriteLine("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();
                    if (username == admin.username && password == admin.password)
                        Console.WriteLine("correct!");
                    else
                        Console.WriteLine("username or password is wrong");
                    ///========= abilities of admin
                    Console.WriteLine("1.Add a patient(a)\n2.List of patients(p)\n3.List of doctors(d)\n3.List of nurses(n)\n5.Exit(e)");
                    //========= add patient
                    if (choose == "a")
                    {
                        Patient patient = new Patient();
                        Console.WriteLine("First Name: "); patient.firstname = Console.ReadLine();
                        Console.WriteLine("Last Name: "); patient.lastname = Console.ReadLine();
                        Console.WriteLine("Id: "); patient.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sickness: "); patient.sickness = Console.ReadLine();
                        Console.WriteLine("Doctor: "); patient.doctor = Console.ReadLine();
                        Console.WriteLine("Room Number"); patient.Room_number = int.Parse(Console.ReadLine());
                        patient_count++;
                        Console.WriteLine("Patient added successfully!");
                    }
                    else if (choose == "p")
                    {

                    }
                    else if (choose == "d") { }
                    else if (choose == "n") { }
                    else if (choose == "e") { break; }

                }//===== end admin
                //=====Doctor menu
                else if (choose == "d")
                {
                    Console.WriteLine("1.Visit patient(v)\n2.Prescribe(p)\n3.Exit(e)");
                    choose = Console.ReadLine();
                    if (choose == "p")
                    {
                        Console.WriteLine("Enter Name or Id: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Write drugs: something");
                        Console.WriteLine("prescribe successfully!");
                    }
                    else if(choose == "v")
                    {
                        Console.WriteLine("visit successfully!");
                    }
                    else if (choose == "e") { break; }
                }
                //====== end doctor menu


            }




        }
    }
}
