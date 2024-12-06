using System;

namespace Bilforhandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Hello, World!");
            Car car1 = new Car("Mercedes", "SEC", 2022, "KT60347", 56000.5, 5500);
            Console.WriteLine(car1.GetBrand());
            Person person1 = new Person("Stian", 100000);
            CarStore carStore1 = new CarStore("Pelle");
            carStore1.AddCar(car1);
            Console.WriteLine(carStore1._carStoreName);


            string userReply = askUserForInput("Velg alternativ 1 2 eller 3", ["1", "2", "3"]);

            switch (userReply)
            {
                case "1":
                    if (carStore1.SellCar(car1))
                    {
                        person1.Purchase(car1);
                    }

                    break;
                case "2":
                    car1.GetMake();
                    break;
                case "3":
                    //doSomethignThird();
                    break;
            }
        }

        public static string askUserForInput(string query, string[] validReplies)
        {
            while (true)
            {
                Console.Write(query);
                string userReply = Console.ReadLine();
                if (validReplies.Contains(userReply))
                {
                    return userReply;
                }
            }
        }
    }
}
