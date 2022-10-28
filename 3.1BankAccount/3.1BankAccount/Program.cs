using System;

class customer
{
    protected String cust_name, bank, ph_no, email, address;
    protected int age;
    protected char gender;
    public void customer1(String cust_name, String bank, String ph_no, int age, String email, char gender, String address)
    {
        this.cust_name = cust_name;
        this.bank = bank;
        this.ph_no = ph_no;
        this.age = age;
        this.email = email;
        this.gender = gender;
        this.address = address;
    }


}

class account : customer
{
    int no = 130;
    protected long account_no;
    int balance;
    protected String branch_name, account_type;

    public void account1(long account_no, int balance, String branch_name, String account_type)
    {

        this.account_no = account_no;
        this.balance = balance;
        this.branch_name = branch_name;
        this.account_type = account_type;

    }

    public void acct_details()
    {
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("ACCOUNT DETAILS");
        for (int k = 0; k < no; k++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        Console.WriteLine("CUSTOMER NAME: " + cust_name);
        Console.WriteLine("BANK:          " + bank);
        Console.WriteLine("BRANCH NAME:  " + branch_name);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("ACCOUNT TYPE:  " + account_type);
        Console.WriteLine("ACCOUNT NO:    " + account_no);
        Console.WriteLine("BALANCE:       " + balance);
        Console.WriteLine();

        for (int k = 0; k < no; k++)
        {
            Console.Write("-");
        }

    }

}

class loan : account
{
    int no = 130;
    String loan_reason;
    int loan_no, credited_amt, amt_paid, amt_to_be_paid;
    String interest;
   

    public void loan1(String loan_reason, int loan_no, int credited_amt, int amt_paid, int amt_to_be_paid, String interest)
    {
        this.loan_reason = loan_reason;
        this.loan_no = loan_no;
        this.credited_amt = credited_amt;
        this.amt_paid = amt_paid;
        this.amt_to_be_paid = amt_to_be_paid;
        this.interest = interest;
     
    }

    public void cust_details()
    {
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("CUSTOMER DETAILS");
        for (int k = 0; k < no; k++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        Console.WriteLine("CUSTOMER NAME: " + cust_name);
        Console.WriteLine("BANK:          " + bank);
        Console.WriteLine("EMAIL:         " + email);
        Console.WriteLine("AGE:           " + age);
        Console.WriteLine("PHONE NO:      " + ph_no);
        Console.WriteLine("GENDER:        " + gender);
        Console.WriteLine("ACCOUNT NO:    " + account_no);
        Console.WriteLine("ADDRESS:       " + address);



        Console.WriteLine();

        for (int k = 0; k < no; k++)
        {
            Console.Write("-");
        }

    }
    public void loan_details()
    {
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("LOAN DETAILS");
        for (int k = 0; k < no; k++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        Console.WriteLine("CUSTOMER NAME:" + cust_name);
        Console.WriteLine("EMAIL        :" + email);
        Console.WriteLine("AGE          :" + age);
        Console.WriteLine("PHONE NO NO  :" + ph_no);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("LOAN REASON:         " + loan_reason);
        Console.WriteLine("LOAN NO:             " + loan_no);
        Console.WriteLine("INTEREST:            " + interest);
        Console.WriteLine("LOAN CREDITED AMOUNT:" + credited_amt);
        Console.WriteLine("AMOUNT PAID          " + amt_paid);
        Console.WriteLine("AMOUNT TO BE PAID:   " + amt_to_be_paid);





        Console.WriteLine();

        for (int k = 0; k < no; k++)
        {
            Console.Write("-");
        }
    }
}

class program
{
    public static void Main(String[] args)
    {
        account a = new account();
        loan l = new loan();
        l.customer1("Rohit Ranjan Kumar", "SBI", "8529125772", 22, "rohitranjankumar@gamil.com", 'M', "Hostel-A,Varali,Kalapet");
        a.account1(36013032759, 1723, "Bapudham", "Saving");
        l.loan1("education", 171523, 495000, 295000, 200000, "1.2%");

        l.cust_details();
        a.acct_details();
        l.loan_details();
    }
}