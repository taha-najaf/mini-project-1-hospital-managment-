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
            int d=2,n=2,p=0;//d for doctor,n for nurses ,p for patient counter
            //defualt doctors + doctor arr
            Doctor []doctors=new Doctor[200];
            doctors[0] = new Doctor("Mohammad","Amiri",8962, "heart specialist", 20);
            doctors[1] = new Doctor("Amir", "Mohammadi", 8932, "Neurologist", 30);
            //defult nurses + nurse arr
            Nurse[] nurses = new Nurse[200];
            nurses[0] = new Nurse("Azita", "Soufian", 6432);
            nurses[1] = new Nurse("Parisa", "Nabavi", 6481);
            //patient arr
            Patient[] patients = new Patient[200];
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
                    {
                        Console.WriteLine("username or password is wrong");
                        continue;
                    }
                    ///========= abilities of admin
                    Console.WriteLine("1.Add a patient(a)\n2.List of patients(p)\n3.Add a doctor(b)\n4.List of doctors(d)\n5.Add a nurse(c)\n6.List of nurses(n)\n7.Exit(e)");
                    choose = Console.ReadLine();
                    //========= add patient
                    if (choose == "a")
                    {
                        patients[p] = new Patient();
                        Console.WriteLine("First Name: "); patients[p].firstname = Console.ReadLine();
                        Console.WriteLine("Last Name: "); patients[p].lastname = Console.ReadLine();
                        Console.WriteLine("Id: "); patients[p].Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sickness: "); patients[p].sickness = Console.ReadLine();
                        Console.WriteLine("Doctor: "); patients[p].doctor = Console.ReadLine();
                        Console.WriteLine("Room Number"); patients[p].Room_number = int.Parse(Console.ReadLine());
                        p++;
                        Console.WriteLine("Patient added successfully!");
                    } // list of patient
                    else if (choose == "p")
                    {

                    }
                    // add doctor
                    else if(choose=="b")
                    {
                        Console.WriteLine("Enter firstname: "); string firstname = Console.ReadLine();
                        Console.WriteLine("Last Name: ");       string lastname = Console.ReadLine();
                        Console.WriteLine("Id: ");              int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Speciality: ");      string speciality = Console.ReadLine();
                        Console.WriteLine("record: ");          int record = int.Parse(Console.ReadLine());
                        doctors[d] = new Doctor(firstname,lastname,id,speciality,record);
                        d++;
                        Console.WriteLine("Doctor added successfully!");
                    }//list of doctor 
                    else if (choose == "d") { }
                    //add nurse
                    else if (choose=="c")
                    {
                        Console.WriteLine("Enter firstname: "); string firstname = Console.ReadLine();
                        Console.WriteLine("Last Name: "); string lastname = Console.ReadLine();
                        Console.WriteLine("Id: "); int id = int.Parse(Console.ReadLine());
                        nurses[n]=new Nurse(firstname,lastname,id);
                        n++;
                        Console.WriteLine("Nurse added successfully!");
                    }// list of nurse 
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
                //======Nurse menu
                else if(choose=="n")
                {
                    Console.WriteLine("1.Treat patient(t)\n2.Exit(e)");
                    choose= Console.ReadLine();
                    if(choose=="t")
                    {
                        Console.WriteLine("Enter id or name: ");
                        Console.ReadLine();
                        Console.WriteLine("patient treat successfully!");
                    }
                }


            }

            Console.WriteLine("Thank for using our system!!");


        }
    }
}
