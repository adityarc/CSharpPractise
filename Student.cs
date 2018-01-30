using System;
using System.Collections;


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
            Stack S1 = new Stack();
            //Student stud = new Student();
            char ch;
            Console.Write("\nEnter the Student Details:\n\n");
            do
            {
                Student stud = new Student();
                Console.Write("Student ID:\t");
                stud.StudentId = int.Parse(Console.ReadLine());
                Console.Write("Student Name:\t");
                stud.Name = Console.ReadLine();
                Console.Write("Mobile No.:\t");
                stud.MobileNo = Console.ReadLine();
                Console.Write("City:\t");
                stud.city = Console.ReadLine();

                S1.Push(stud);

                Console.WriteLine("\nDo you want to enter more details (Y|N):");
                ch = char.Parse(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');
            Console.Clear();
            Console.WriteLine("\nTHE NUMBER OF STUDENTS IS:\t" + S1.Count + "\nThe Details of the students are displayed as follows \n");
            foreach (Student s in S1)
            {

                Console.WriteLine("Student ID:\t {0} \nStudent Name:\t {1} \nMobile No.:\t {2} \n City:\t {3}\n\n\n ", s.StudentId, s.Name, s.MobileNo, s.city);


            }
            //while(S1.Count != 0)
            //{
            //    Student s = (Student) S1.Pop();
            //    Console.WriteLine("Student ID:\t {0} \nStudent Name:\t {1} \nMobile No.:\t {2} \n City:\t {3}\n\n\n ", s.StudentId, s.Name, s.MobileNo, s.city);

            //}
        }


    }
}
