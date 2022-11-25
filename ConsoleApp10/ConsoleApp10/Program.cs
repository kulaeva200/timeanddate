using System;
using System.Globalization;

namespace ConsoleApp10
{
    class Program
    {
       // Console.WriteLine("");
        static void Main(string[] args)
        {
            //Метод ParseExact
            Console.WriteLine("Метод ParseExact:");
            string date = "05112022";
            DateTime dt = DateTime.ParseExact(date, "ddMMyyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dt);


            //Метод Parse
            Console.WriteLine("Метод Parse:");
            string[] strDate = new string[]
                          { 
    "10/10/2022 07:22:16",
    "10/10/2022",
    "10/2022",
    "10/22",
    "07:22:16",
    "7 PM",
    "2022-10-10T07:22:16.0000000Z",
    "2022-10-10T07:22:16.0000000-07:00",
    "Thu, 10 Nov 2022 07:22:16 GMT",
    "10/10/2022 07:22:16 -5:00"
};
            foreach (string str in strDate)
            {
                DateTime d = DateTime.Parse(str, CultureInfo.GetCultureInfo("en-US"));
                Console.WriteLine($"{d}");
            }


            //Методы TryParse и TryParseExact
            Console.WriteLine("Методы TryParse и TryParseExact:");
            string[] Date = new string[]
{
      "10/10/2022 07:22:16",
    "10/10/2022",
    "10/2022",
    "10/22",
    "07:22:16",
    "7 PM",
    "2022-10-10T07:22:16.0000000Z",
    "2022-10-10T07:22:16.0000000-07:00",
    "Thu, 10 Nov 2022 07:22:16 GMT",
    "10/10/2022 07:22:16 -5:00"
};
            foreach (string str in Date)
            {
                DateTime tm;
                if (DateTime.TryParse(str, out tm))
                {
                    Console.WriteLine($"{tm}");
                }
                else
                    Console.WriteLine("Ошибка");


            }

        }


    }
}

