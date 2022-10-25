using System;
using System.Data;
using System.Net.Http.Headers;

class shop
{
    string[] product = new string[5];
    int[] quantity = new int[5];
    double[] price = new double[5];
    double[] total = new double[5];
    string val;
    double amount, x = 0;
    int no;
    public string[] Name
    {
        get { return product; }
        set { product = value; }
    }
    public int[] Number
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public double[] Cost
    {
        get { return price; }
        set { amount = Convert.ToDouble(value); }
    }

    public void input()
    {
        Console.WriteLine("Enter the Products & Price\n\n");

        for (int i = 0; i < Name.Length; i++)
        {
            Console.Write("Product {0}:  ", i + 1);
            val = Console.ReadLine();
            Name[i] = val;
            Console.Write("Quantity:  ");
            no = int.Parse(Console.ReadLine());
            Number[i] = no;
            Console.Write("Price:  ");
            amount = Double.Parse(Console.ReadLine());
            Cost[i] = amount;
            Console.WriteLine("\n");
        }
    }
    public void output()
    {
        Console.WriteLine("\n\n     " + "PRODUCT\t" + "QUANTITY\t" + "UNIT PRICE\t" + "TOTAL PRICE\n");
        for (int j = 0; j < Name.Length; j++)
        {
            total[j] = (Number[j] * Cost[j]);
            Console.WriteLine("     " + Name[j] + "\t\t" + Number[j] + "\t\t" + Cost[j] + "\t\t" + total[j]);
            x += total[j];
        }

        Console.WriteLine("\n\nTOTAL PRICE:  " + x);
    }

}

class bill
{
    public static void Main(string[] args)
    {
        shop s = new shop();
        s.input();
        s.output();
    }
}