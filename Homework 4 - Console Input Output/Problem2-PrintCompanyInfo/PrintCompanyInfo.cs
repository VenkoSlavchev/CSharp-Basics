using System;

namespace Problem2_PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            Console.Write("Company Name :");
            string name = Console.ReadLine();
            Console.Write("Company Adress :");
            string adress = Console.ReadLine();
            Console.Write("Company Number :");
            string cphone = Console.ReadLine();
            Console.Write("Company Fax Number :");
            string fax = Console.ReadLine();
            Console.Write("Company Web Site :");
            string web = Console.ReadLine();
            Console.Write("Manager's first Name :");
            string firstname = Console.ReadLine();
            Console.Write("Manager's last Name :");
            string lastname = Console.ReadLine();
            Console.Write("Manager's age :");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Manager's phone number :");
            string mphone =Console.ReadLine();
            Console.WriteLine("{0}\nAdress: {1}\nTel: {2}\n{3}Fax: nofax\nWebSite: {4}\nManager:{5} {6}\n(Age: {7} tel {8})",name,adress,cphone,fax,web,firstname,lastname,age,mphone);

        }
    }
}
