using System;
using System.Net.Http.Headers;
using System.Transactions;
using System.Xml.Schema;

class bill
{
    string[] item = new string[5];
    double[] price = new double[5];
    int[] quantity = new int[5];
    double[] sum = new double[5];
    string date;


    public bill()
    {
        Console.WriteLine("Enter the date:");
        date = Console.ReadLine();
        Console.WriteLine("\n\n Enter the product, price and quantity");
        for(int i=0; i<item.Length;i++ )
        {
            Console.Write("\n\n Product {0}: ", i + 1);
            item[i] = Console.ReadLine();
            Console.Write(" " + " Price:");
            price[i] = double.Parse(Console.ReadLine());
            Console.Write(" " + "Qauntity:");
            quantity[i] = int.Parse(Console.ReadLine());
        }

    }
    public bill (bill temp)
    {
        item = temp.item;
        price = temp.price;
        quantity = temp.quantity;
        date = temp.date;
        double total = 0;
        for(int i=0; i<price.Length;i++)
        {
            sum[i] = (price[i] * quantity[i]);
            total += sum[i];
        }
        Console.WriteLine("\n\nDATE:" + date);
        Console.WriteLine("\n\n " + "PRODUCT NAME \t\t" + "QUANTITY\t\t" + "PRICE\t\t" + "TOTAL PRICE \n\n");
        for(int i=0; i<item.Length;i++)
        {
            Console.WriteLine(" " + item[i] + "\t\t\t\t" + quantity[i] + "\t\t" + price[i] + "\t\t" + sum[i]);
        }
        Console.WriteLine("\n\n TOTAL AMOUNT: " + total);
    }
}

namespace _2._2Bill_ConstructionOverloading_
{
    class Program
    {
        static void Main(string[] args)
        {
            bill b = new bill();
            bill b1 = new bill(b);
        }
    }
}
