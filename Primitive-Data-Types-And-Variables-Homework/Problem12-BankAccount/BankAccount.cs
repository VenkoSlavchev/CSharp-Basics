using System;

namespace Problem12_BankAccount
{
    class BankAccount
    {
        static void Main()
        {
            string firstName = "Johny";
            string middleName = "Long";
            string lastName = "Truman";
            decimal money = 350.15M;
            string bankName = "WestCoast";
            string iban = "BG04SDEB34532183423587"; 
            string cc1 = "4456324535963597"; 
            string cc2 = "4456324535963598"; 
            string cc3 = "4456324535963599";
            Console.Write("{0} " + "{1} " + "{2} ", firstName, middleName, lastName);

            Console.WriteLine(money + "$");
            Console.WriteLine(bankName + " ");
            Console.WriteLine(iban);
            Console.WriteLine(cc1);
            Console.WriteLine(cc2);
            Console.WriteLine(cc3);
        }
    }
}
