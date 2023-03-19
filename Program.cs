using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_1_hospital_managment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // add persian time
            DateTime now = DateTime.Now;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(now.ToPersianDateTime());
            Console.BackgroundColor = ConsoleColor.Black;
            //===============
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
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("choose one :");
                Console.BackgroundColor= ConsoleColor.Black;
                Console.WriteLine("Admin(a)\nDoctor(d)\nNurse(n)\nExit(e)");
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
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("correct!");
                        Console.BackgroundColor= ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("username or password is wrong");
                        Console.BackgroundColor = ConsoleColor.Black;
                        continue;
                    }
                    ///========= abilities of admin
                    Console.WriteLine("1.Add a patient(a)\n2.List of patients(p)\n3.Add a doctor(b)\n4.List of doctors(d)\n5.Add a nurse(c)\n6.List of nurses(n)\n7.Exit(e)");
                    choose = Console.ReadLine();
                    // list of patient
                    if (choose == "p")
                    {
                        if (p == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("There is not any patient in the hospital!");
                        }
                        for (int i = 0; i < p; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Information of patient {0}: ", i + 1);
                            patients[i].information_patient();

                        }
                    }
                    //========= add patient
                    else if (choose == "a")
                    {
                        patients[p] = new Patient();
                        Console.WriteLine("First Name: "); patients[p].firstname = Console.ReadLine();
                        Console.WriteLine("Last Name: "); patients[p].lastname = Console.ReadLine();
                        Console.WriteLine("National code: "); patients[p].national_code = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sickness: "); patients[p].sickness = Console.ReadLine();
                        Console.WriteLine("Doctor: "); patients[p].doctor = Console.ReadLine();
                        Console.WriteLine("Room Number: "); patients[p].Room_number = Console.ReadLine();
                        p++;
                        Console.BackgroundColor= ConsoleColor.Green;
                        Console.WriteLine("Patient added successfully!");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    // add doctor
                    else if (choose == "b")
                    {
                        Console.WriteLine("Enter firstname: "); string firstname = Console.ReadLine();
                        Console.WriteLine("Last Name: "); string lastname = Console.ReadLine();
                        Console.WriteLine("Id: "); int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Speciality: "); string speciality = Console.ReadLine();
                        Console.WriteLine("record: "); int record = int.Parse(Console.ReadLine());
                        doctors[d] = new Doctor(firstname, lastname, id, speciality, record);
                        d++;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doctor added successfully!");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }//list of doctor 
                    else if (choose == "d")
                    {
                        for (int i = 0; i < d; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Information of doctor {0}: ", i + 1);
                            doctors[i].information_doctors();

                        }
                    }
                    //add nurse
                    else if (choose == "c")
                    {
                        Console.WriteLine("Enter firstname: "); string firstname = Console.ReadLine();
                        Console.WriteLine("Last Name: "); string lastname = Console.ReadLine();
                        Console.WriteLine("Id: "); int id = int.Parse(Console.ReadLine());
                        nurses[n] = new Nurse(firstname, lastname, id);
                        n++;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nurse added successfully!");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }// list of nurse 
                    else if (choose == "n")
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Information of nurse {0} : ", i + 1);
                            nurses[i].information_nurses();

                        }
                    }
                    else if (choose == "e") { break; }
                }


                //==================================================================== end admin
                //Doctor menu
                else if (choose == "d")
                {
                    Console.WriteLine("1.Visit patient(v)\n2.Prescribe(p)\n3.Exit(e)");
                    choose = Console.ReadLine();
                    if (choose == "p")
                    {
                        Console.WriteLine("Enter Name or Id: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Write drugs: something");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("prescribe successfully!");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (choose == "v")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("visit successfully!");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (choose == "e") { break; }
                }
                //====== end doctor menu
                //======Nurse menu
                else if (choose == "n")
                {
                    Console.WriteLine("1.Treat patient(t)\n2.Exit(e)");
                    choose = Console.ReadLine();
                    if (choose == "t")
                    {
                        Console.WriteLine("Enter National_Code : ");
                        int id=int.Parse(Console.ReadLine());
                        Nurse.treat(id,patients);
                    }
                }
                else if (choose == "e")
                    break;


            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Thank for using our system!!");
            Console.ReadKey();


        }
    }
}
