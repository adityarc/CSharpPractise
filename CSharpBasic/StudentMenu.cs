using System;
using System.Collections.Generic;


namespace AdisNamespace
{
    class Student
    {
        string _MobileNo;
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string MobileNo
        {
            get { return _MobileNo; }
            set
            {
                if (value.Length == 10)
                {
                    _MobileNo = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input! Not Accepted.");


                }
            }

        }
        public string city { get; set; }
        static void Main(string[] args)
        {
            List<Student> S1 = new List<Student>();
            //Student stud = new Student();
            char ch; int c;

            do
            {
                Console.WriteLine("\nTHE NUMBER OF STUDENTS IS:\t" + S1.Count + "\n\nSelect an option. \n1. Get Student Details \n2. Search Student \n3. Remove \n4. Print Details");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Student stud = new Student();
                        Console.Write("Student ID:\t");
                        stud.StudentId = int.Parse(Console.ReadLine());
                        Console.Write("Student Name:\t");
                        stud.Name = Console.ReadLine();
                        Console.Write("Mobile No.:\t");
                        stud.MobileNo = Console.ReadLine();
                        Console.Write("City:\t");
                        stud.city = Console.ReadLine();
                        S1.Add(stud);
                        break;
                    case 2:
                        Console.Write("Enter the Student ID to be searched:\t");
                        int id = int.Parse(Console.ReadLine());
                        int flag = 0;
                        foreach (Student s in S1)
                        {
                            if (s.StudentId == id)
                            {
                                Console.WriteLine("Student ID:\t {0} \nStudent Name:\t {1} \nMobile No.:\t {2} \n City:\t {3}\n\n\n ", s.StudentId, s.Name, s.MobileNo, s.city);
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            Console.Write("Student Not Found!\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the Mobile Number of the student to be removed:");
                        string pno = Console.ReadLine();
                        int f = 0;
                        foreach (Student s in S1)
                        {
                            if (s.MobileNo == pno)
                            {
                                S1.Remove(s);
                                f = 1;
                                break;
                            }
                        }
                        if (f == 0)
                        {
                            Console.Write("Student Not Found!\n");
                        }
                        break;
                    case 4:
                        foreach (Student s in S1)
                        {
                            
                            
                                Console.WriteLine("Student ID:\t {0} \nStudent Name:\t {1} \nMobile No.:\t {2} \n City:\t {3}\n\n\n ", s.StudentId, s.Name, s.MobileNo, s.city);
                                
                                
                        }
                        break;
                    default:
                        Console.WriteLine("WRONG OPTION INPUT!!!");
                        break;
                }
                        Console.WriteLine("\nDo you want continue (Y|N):");
                        ch = char.Parse(Console.ReadLine());

                } while (ch == 'y' || ch == 'Y') ;
                Console.Clear();

                foreach (Student s in S1)
                {

                    Console.WriteLine("Student ID:\t {0} \nStudent Name:\t {1} \nMobile No.:\t {2} \n City:\t {3}\n\n\n ", s.StudentId, s.Name, s.MobileNo, s.city);


                }

            }


    }
    }
