using System;

interface vehicle
{
    public void calc_emi();
}

interface loan
{

    public void loan_details(double p, double r, double n);
}

class car : vehicle, loan
{
    double amt_lost;
    double emi;
    double p, n;
    double r;
    public void loan_details(double p, double r, double n)
    {
        this.p = p;
        this.r = ((r / 100) / 12);
        this.n = (n * 12);
    }

    public void calc_emi()
    {
        emi = (p * r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n) - 1);
        Console.WriteLine(" EMI PER MONTH FOR CAR IS       :" + emi);
        Console.WriteLine();
        Console.WriteLine("THE ACTUAL AMONT OF CAR         :" + p);
        Console.WriteLine();
        Console.WriteLine("THE TOTAL AMOUNT PAID WITH EMI  :" + (emi * n));
        Console.WriteLine();
        amt_lost = (emi * n) - p;
        Console.WriteLine(" the loss due to EMI payment IS :" + amt_lost);
        Console.WriteLine();
    }



}


class bike : vehicle, loan
{
    double amt_lost;
    double emi;
    double p, n;
    double r;
    public void loan_details(double p, double r, double n)
    {
        this.p = p;
        this.r = ((r / 100) / 12);
        this.n = (n * 12);
    }

    public void calc_emi()
    {
        emi = (p * r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n) - 1);
        Console.WriteLine(" EMI PER MONTH FOR BIKE IS             :" + emi);
        Console.WriteLine();
        Console.WriteLine("THE ACTUAL AMONT OF BIKE               :" + p);
        Console.WriteLine();
        Console.WriteLine("THE TOTAL AMOUNT PAID WITH EMI         :" + (emi * n));
        Console.WriteLine();
        amt_lost = (emi * n) - p;
        Console.WriteLine(" THE AMOUNT LOST DUE TO EMI PAYMENT IS :" + amt_lost);
        Console.WriteLine();


    }



}


class program
{
    public static void Main(String[] args)
    {
        int no = 130;
        car c = new car();
        c.loan_details(885000.0, 13.0, 2.0);
        c.calc_emi();
        Console.WriteLine();

        for (int k = 0; k < no; k++)
        {
            Console.Write("-");
        }
        Console.WriteLine();

        bike b = new bike();
        b.loan_details(89000, 12, 3);
        b.calc_emi();
        Console.ReadKey();
    }
}