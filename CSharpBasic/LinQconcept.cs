using System;
using System.Collections.Generic;
using System.Linq;


namespace AdisNamespace
{
    class Project
    {
        public int ProjectID;
        public string ProjectName;
        public int EmpID;
    }
    class Emp
    {
        public int ID;
        public string Name;
        public double salary;

        static void Main(string[] args)
        {
            
            double[] sal = new double[] { 345, 678, 234, 789, 234, 675 };
            var q = from obj in sal select obj;
            foreach (var k in q)
                Console.WriteLine(k);

            Console.ReadKey();
            Console.Clear();

            List<Emp> L1 = new List<Emp>();
            L1.Add(new Emp { ID = 1, Name = "ABA", salary = 12343});
            L1.Add(new Emp { ID = 2, Name = "BBA", salary = 45645});
            L1.Add(new Emp { ID = 3, Name = "CAC", salary = 45764});
            L1.Add(new Emp { ID = 4, Name = "ACS", salary = 67867});
            L1.Add(new Emp { ID = 5, Name = "DAA", salary = 56756});
            

            List<Project> L2 = new List<Project>();
            L2.Add(new Project { ProjectID = 1, ProjectName = "Shell", EmpID = 1 });
            L2.Add(new Project { ProjectID = 2, ProjectName = "Lorenzo", EmpID = 3 });
            L2.Add(new Project { ProjectID = 3, ProjectName = "Shell", EmpID = 2 });
            L2.Add(new Project { ProjectID = 4, ProjectName = "Lorenzo", EmpID = 4 });
            L2.Add(new Project { ProjectID = 5, ProjectName = "Lorenzo", EmpID = 5 });

            var q1 = from emp in L1 join prj in L2 on emp.ID equals prj.EmpID
                     select new {
                         EmpName = emp.Name,
                         ProjectName = prj.ProjectName,
                         EmpSalary = emp.salary
                     };

            foreach (var k in q1)
                Console.WriteLine(k.EmpName + "\t"+k.ProjectName + "\t"+k.EmpSalary);
        }
    }
}
