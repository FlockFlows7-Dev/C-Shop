using System;

class Program
{
    public static void Main(string[] args)
    {

        float money = 25.00f;

        string restart = "";

        int ownedapples = 0;
        int ownedoranges = 0;
        int ownedbananas = 0;
        bool indebt = false;
        Console.WriteLine("___________________________________________________");
        Console.WriteLine("| Welcome to Fruits Galore                        |");
        Console.WriteLine("|                                                 |");
        Console.WriteLine("| Fruit Prices                                    |");
        Console.WriteLine("| apples  $3.00                                   |");
        Console.WriteLine("| oranges $2.00                                   |");
        Console.WriteLine("| bananas $1.00                                   |");
        Console.WriteLine("|                                                 |");
        Console.WriteLine("| Balance " + money + ".00 dollars" + "\t\t\t\t\t\t      |");
        Console.WriteLine("|_________________________________________________|");
        Console.WriteLine("how many apples do you want to buy?");
        ownedapples = int.Parse(Console.ReadLine());
        money -= ownedapples * 3;
        Console.WriteLine("how many oranges do you want to buy?");
        ownedoranges = int.Parse(Console.ReadLine());
        money -= ownedoranges * 1;
        Console.WriteLine("how many bananas do you want to buy?");
        ownedbananas = int.Parse(Console.ReadLine());
        money -= ownedbananas * 2;
        Console.Clear();


        if (money < 0)
        {
            indebt = true;
        }
        Console.WriteLine("___________________________________________________");
        Console.WriteLine("|                                                 |");
        if (indebt == true)
        {
            Console.WriteLine("| you are in debt due to buying to many items :(  |");
        }
        else
        {
            Console.WriteLine("| Your change $" + money + ".00 \t\t\t\t\t\t\t  |");
        }
        Console.WriteLine("|_________________________________________________|");

        Console.WriteLine("(Shop again? Press enter)");
        restart = (Console.ReadLine());
        Console.Clear();
        Main(args);
    }
}