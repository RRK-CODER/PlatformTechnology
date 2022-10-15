using System;

namespace Indexers
{
    class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }

    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        Employee[] EmpList;

        public Department()
        {
            DeptId = 10;
            DeptName = "Sales";
            EmpList = new Employee[3]
            {
                new Employee { Id = 101, EmpName = "Ram", Salary = 50000 },
                new Employee { Id = 102, EmpName = "Sita", Salary = 45000 },
                new Employee { Id = 103, EmpName = "Bharat", Salary = 40000 }
            };
        }

        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in EmpList)
            {
                if (id == emp.Id)
                    return emp;
            }
            return null;
        }
        public Employee GetEmployee(string name)
        {
            foreach (Employee emp in EmpList)
            {
                if (name == emp.EmpName)
                    return emp;
            }
            return null;
        }

        public Employee this[int id]
        {
            get
            {
                foreach (Employee emp in EmpList)
                {
                    if (id == emp.Id) return emp;
                }
                return null;
            }
        }

        public Employee this[string name]
        {
            get
            {
                foreach (Employee emp in EmpList)
                {
                    if (name == emp.EmpName) return emp;
                }
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department();
            Console.WriteLine(dept[101].EmpName);
            Console.WriteLine(dept["Ram"].Id);
        }
    }
}