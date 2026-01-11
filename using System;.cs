using System;

class Program
{
    static void Main(string[] args)
    {
        CoffeeMachine machine = new CoffeeMachine(2000, 200, 100, 100);

        while (true)
        {
            Console.WriteLine("===== Coffee Machine =====");
            Console.WriteLine("1. กาแฟดำ");
            Console.WriteLine("2. มอคค่า");
            Console.WriteLine("3. ลาเต้");
            Console.WriteLine("4. ช็อกโกแลต");
            Console.WriteLine("0. ออก");
            Console.Write("เลือกเมนู: ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 0) break;

            Drink drink = null;

            switch (choice)
            {
                case 1: drink = Drink.BlackCoffee(); break;
                case 2: drink = Drink.Mocha(); break;
                case 3: drink = Drink.Latte(); break;
                case 4: drink = Drink.Chocolate(); break;
                default:
                    Console.WriteLine("เลือกไม่ถูกต้อง");
                    continue;
            }

            machine.MakeDrink(drink);
            Console.WriteLine();
        }
    }
}
