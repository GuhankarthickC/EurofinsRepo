using Addoreference;
using System;

namespace Addodotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            /*c.SelectData();*/
            Console.WriteLine("Enter eid,fname,lname,city,country,phoneno");
            int eid = Convert.ToInt32(Console.ReadLine());
            string efname = Console.ReadLine();
            string elname = Console.ReadLine();
            string city = Console.ReadLine();
            string country = Console.ReadLine();
            string phone = Console.ReadLine();
            c.InsertData(eid, efname, elname, city, country, phone);
        }
    }
}
