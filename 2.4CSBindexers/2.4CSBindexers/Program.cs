using System;
using System.Reflection;
using System.Xml.Schema;

class shop
{
    string product;
    int quantity;
    double price;
    double tprice;
    static double tc;

    public object this[int index]
    {
        get
        {
            if (index == 0)
            {
                return product;
            }
            else if (index == 1)
            {
                return quantity;
            }
            else if (index == 2)
            {
                return price;
            }
            else if (index == 3)
            {
                return tprice;
            }
            else
            {
                return null;
            }
        }
        set
        {
            if (index == 0)
            {
                product = Convert.ToString(value);
            }
            else if (index == 1)
            {
                quantity = Convert.ToInt32(value);
            }
            else if (index == 2)
            {
                price = Convert.ToDouble(value);
            }
            else if (index == 3)
            {
                tprice = Convert.ToDouble(value);
            }

        }
    }

    public static void Main(string[] args)
    {
        shop a = new shop();
        Console.WriteLine("\t\t\tEnter the Product's & Price Name\n\n");
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Console.Write("Product: ");
                a[i] = Console.ReadLine();
                continue;
            }
            else if (i == 1)
            {
                Console.Write("Quantity: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                continue;
            }
            else if (i == 2)
            {
                Console.Write("Price: ");
                a[i] = Convert.ToDouble(Console.ReadLine());
                continue;
            }

        }
        shop b = new shop();

        Console.WriteLine("\n\n");

        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Console.Write("Product: ");
                b[i] = Console.ReadLine();
                continue;
            }
            else if (i == 1)
            {
                Console.Write("Quantity: ");
                b[i] = Convert.ToInt32(Console.ReadLine());
                continue;
            }
            else if (i == 2)
            {
                Console.Write("Price: ");
                b[i] = Convert.ToDouble(Console.ReadLine());
                continue;
            }

        }
        shop c = new shop();
        Console.WriteLine("\n\n");

        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Console.Write("Product: ");
                c[i] = Console.ReadLine();
                continue;
            }
            else if (i == 1)
            {
                Console.Write("Quantity: ");
                c[i] = Convert.ToInt32(Console.ReadLine());
                continue;
            }
            else if (i == 2)
            {
                Console.Write("Price: ");
                c[i] = Convert.ToDouble(Console.ReadLine());
                continue;
            }

        }
        shop d = new shop();
        Console.WriteLine("\n\n");

        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Console.Write("Product: ");
                d[i] = Console.ReadLine();
                continue;
            }
            else if (i == 1)
            {
                Console.Write("Quantity: ");
                d[i] = Convert.ToInt32(Console.ReadLine());
                continue;
            }
            else if (i == 2)
            {
                Console.Write("Price: ");
                d[i] = Convert.ToDouble(Console.ReadLine());
                continue;
            }

        }


        shop e = new shop();

        Console.WriteLine("\n\n");

        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Console.Write("Product: ");
                e[i] = Console.ReadLine();
                continue;
            }
            else if (i == 1)
            {
                Console.Write("Quantity: ");
                e[i] = Convert.ToInt32(Console.ReadLine());
                continue;
            }
            else if (i == 2)
            {
                Console.Write("Price: ");
                e[i] = Convert.ToDouble(Console.ReadLine());
                continue;
            }

        }

        Console.WriteLine("\n\n\n" + "   " + "PRODUCT\t" + "QUANTITY\t" + "PRICE\t\t" + "TOTAL PRICE\n");


        a.tprice = a.quantity * a.price;
        b.tprice = b.quantity * b.price;
        c.tprice = c.quantity * c.price;
        d.tprice = d.quantity * d.price;
        e.tprice = e.quantity * e.price;

        for (int j = 0; j < 4; j++)
        {
            Console.Write("   " + a[j] + "\t\t");
        }
        Console.WriteLine("\n");
        for (int j = 0; j < 4; j++)
        {
            Console.Write("   " + b[j] + "\t\t");
        }
        Console.WriteLine("\n");
        for (int j = 0; j < 4; j++)
        {
            Console.Write("   " + c[j] + "\t\t");
        }
        Console.WriteLine("\n");
        for (int j = 0; j < 4; j++)
        {
            Console.Write("   " + d[j] + "\t\t");
        }
        Console.WriteLine("\n");
        for (int j = 0; j < 4; j++)
        {
            Console.Write("   " + e[j] + "\t\t");
        }
        Console.WriteLine("\n");

        tc = a.tprice + b.tprice + c.tprice + d.tprice + e.tprice;
        Console.WriteLine("\n\n\n    TOTAL AMOUNT: " + tc);
    }

}