using System;

namespace Copy_Constructor
{
    using System;
    namespace copyConstractor
    {
        class employee
        {
            private string name;
            private int age;
            public employee(employee emp)   // declaring Copy constructor.
            {
                name = emp.name;
                age = emp.age;
            }
            public employee(string name, int age)  // Instance constructor.
            {
                this.name = name;
                this.age = age;
            }
            public string Details     // Get deatils of employee
            {
                get
                {
                    return " The age of " + name + " is " + age.ToString();
                }
            }
        }
        class empdetail
        {
            static void Main()
            {
                employee emp1 = new employee("Rohit", 23);  // Create a new employee object.
                employee emp2 = new employee(emp1); // here is emp1 details is copied to emp2.
                Console.WriteLine(emp2.Details);
                Console.ReadLine();
            }
        }
    }


}
