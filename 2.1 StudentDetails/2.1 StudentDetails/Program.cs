using System;
using System.Security.Cryptography.X509Certificates;

class student
{
    int[] sl = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
    string a;
    int i, nfound;
    double cgpa, x = 0;
    string[] name = new string[7] { "ROHIT", "MOHIT", "RAVI", "MANJU", "PRIYA", "JITESH", "JASBIR" };
    string[] dept = new string[7] { "CSE", "E&I", "EEE", "ECE", "IT", "CIVIL", "MECH" };
    string[] reg = new string[7] { "20CS001", "20EI002", "20EE003", "20EC004", "20IT005", "20CI006", "20ME007" };
    string[] subject = new string[5];
    int[] mark = new int[5];
    char[] grade = new char[5];
    int[] num = new int[5];
    public void display()
    {
        Console.WriteLine("\t\t\t\tSTUDENTS LIST \n\n");
        Console.WriteLine("\tSL.NO\t\t REG.NO\t\t NAME\t\t DEPARTMENT\n\n");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("\t" + sl[i] + "\t\t" + reg[i] + "\t\t" + name[i] + "\t\t" + dept[i]);
        }
    }
    public void getdata()
    {
        Console.Write("\n\n" + "   " + "REGISTER NUMBER: ");
        a = Console.ReadLine();
        for (i = 0; i < reg.Length; i++)
        {
            if (a == reg[i])
            {
                nfound = 0;
                break;
            }
            else
            {
                nfound = 1;
            }
        }
        if (nfound == 1)
        {
            Console.WriteLine("\n\n" + "   " + " The Register Number is Not Found");
        }
        else
        {
            Console.Write("\n\n" + "   " + "NAME: " + name[i] + "\n");
            Console.Write("   " + "REGISTER NUMBER: " + reg[i] + "\n");
            Console.Write("   " + "DEPARTMENT: " + dept[i] + "\n");


            if (dept[i] == "CSE")
            {
                subject[0] = "INDUSTRIAL ECONOMICS & MANAGEMENT       ";
                subject[1] = "PLATFORM TECHNOLOGIES                   ";
                subject[2] = "COMPUTER NETWORKS                       ";
                subject[3] = "AUTOMATA THEORY & COMPILER DESIGN       ";
                subject[4] = "ESSENCE OF INDIAN TRADITIONAL KNOWLEDGE ";
            }
            else if (dept[i] == "E&I")
            {
                subject[0] = "INDUSTRIAL INSTRUMENTATION         ";
                subject[1] = "MICROPROCESSOR & APPLICATIONS      ";
                subject[2] = "CONTROL SYSTEMS                    ";
                subject[3] = "ENTREPRENEURSHIP                   ";
                subject[4] = "MEASUREMENTS IN PROCESS INDUSTRIES ";
            }
            else if (dept[i] == "EEE")
            {
                subject[0] = "ANALOG & DIGITAL INTEGRATED CIRCUITS ";
                subject[1] = "POWER ELECTRONICS                    ";
                subject[2] = "MEASUREMENT & INSTRUMENTATION        ";
                subject[3] = "TRANSMISSION & DISTRIBUTION          ";
                subject[4] = "ELECTRICAL MACHINES & CONTROL        ";
            }
            else if (dept[i] == "ECE")
            {
                subject[0] = "DIGITAL SIGNAL PROCESSING & DSP PROCESSORS ";
                subject[1] = "DIGITAL COMMUNICATION                      ";
                subject[2] = "MICROPROCESSORS & MICROCONTROLLERS         ";
                subject[3] = "ENTREPRENEURSHIP                           ";
                subject[4] = "DATA COMMUNICATION NETWORKS                ";
            }
            else if (dept[i] == "IT")
            {
                subject[0] = "DATABASE MANAGEMENT SYSTEMS             ";
                subject[1] = "RESOURCE MANAGEMENT & GRAPH THEORY      ";
                subject[2] = "COMPUTER NETWORKS                       ";
                subject[3] = "INFORMATION CODING TECHNIQUES           ";
                subject[4] = "ESSENCE OF INDIAN TRADITIONAL KNOWLEDGE ";
            }
            else if (dept[i] == "CIVIL")
            {
                subject[0] = "MECHANICS OF MATERIALS                     ";
                subject[1] = "ENVIRONMENTAL ENGINEERING                  ";
                subject[2] = "TRANSPORTATION ENGINEERING                 ";
                subject[3] = "ENTREPRENEURSHIP                           ";
                subject[4] = "DESIGN OF PRE-STRESSED CONCRETE STRUCTURES ";
            }
            else
            {
                subject[0] = "HEAT & MASS TRANSFER              ";
                subject[1] = "MANUFACTURING PROCESSES           ";
                subject[2] = "DYNAMICS OF MACHINES              ";
                subject[3] = "MACHINE DESIGN                    ";
                subject[4] = "INDUSTRIAL ECONOMICS & MANAGEMENT ";
            }
            Console.WriteLine("\n" + "  " + "SUBJECTS");
            for (int j = 0; j < subject.Length; j++)
            {
                Console.Write("  " + subject[j] + "   -   ");
                Console.Write("\t");
                mark[j] = int.Parse(Console.ReadLine());

            }

        }
    }
    public void grades()
    {
        if (nfound == 1)
        {
            Console.WriteLine("\n" + "   " + " GRADE - NULL");
        }
        else
        {
            for (int k = 0; k < subject.Length; k++)
            {
                if (mark[k] >= 90 && mark[k] <= 100)
                {
                    grade[k] = 'S';
                }
                else if (mark[k] >= 80 && mark[k] < 90)
                {
                    grade[k] = 'A';
                }
                else if (mark[k] >= 70 && mark[k] < 80)
                {
                    grade[k] = 'B';
                }
                else if (mark[k] >= 60 && mark[k] < 70)
                {
                    grade[k] = 'C';
                }
                else if (mark[k] >= 50 && mark[k] < 60)
                {
                    grade[k] = 'D';
                }
                else if (mark[k] >= 40 && mark[k] < 50)
                {
                    grade[k] = 'E';
                }
                else if (mark[k] < 40)
                {
                    grade[k] = 'F';
                }
                else
                {
                    grade[k] = '_';
                }

                if (grade[k] == 'S')
                {
                    num[k] = 10;
                }
                else if (grade[k] == 'A')
                {
                    num[k] = 9;
                }
                else if (grade[k] == 'B')
                {
                    num[k] = 8;
                }
                else if (grade[k] == 'C')
                {
                    num[k] = 7;
                }
                else if (grade[k] == 'D')
                {
                    num[k] = 6;
                }
                else if (grade[k] == 'E')
                {
                    num[k] = 5;
                }
                else if (grade[k] == 'F')
                {
                    num[k] = 4;
                }
            }
            for (int j = 0; j < num.Length; j++)
            {
                x += num[j];
            }

            cgpa = (x / 5);
            cgpa = (double)System.Math.Round(cgpa, 2);

        }
    }

    public void printdata()
    {
        if (nfound == 1)
        {
            Console.WriteLine("\n" + "   " + " ---");
        }
        else
        {
            Console.WriteLine("\n\n");
            Console.Write("\n\n" + "   " + "NAME: " + name[i] + "\n");
            Console.Write("   " + "REGISTER NUMBER: " + reg[i] + "\n");
            Console.Write("   " + "DEPARTMENT: " + dept[i] + "\n\n");
            Console.Write("   " + "CGPA: " + "{0:00.0}", cgpa + "\n\n");
            Console.WriteLine("\n\t" + "SUBJECT\t\t\t\t\t" + "  " + "MARKS\t\t" + "  " + "GRADE\n\n");
            for (int i = 0; i < subject.Length; i++)
            {
                Console.WriteLine("  " + subject[i] + "\t\t" + mark[i] + "\t\t" + grade[i]);
            }

        }

    }
    public static void Main(string[] args)
    {
        student s = new student();
        s.display();
        s.getdata();
        s.grades();
        s.printdata();
    }
}
