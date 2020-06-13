using System;

namespace ConsoleApp2
{
    class Абонент
    {
        public int indef_num;
        public string Surname;
        public string Name;
        public string Otchestvo;
        private int BankCard;
        private int CountryTime;
        private int CityTime;
      
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Абонент p1 = new Абонент();
            Console.WriteLine("Введите идентификационный номер");
            p1.indef_num=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя");
            p1.Name =Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            p1.Surname = Console.ReadLine();
            Console.WriteLine("Введите Отчество");
            p1.Otchestvo = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(p1.indef_num+"\t"+ p1.Name + "\t"+ p1.Surname + "\t"+ p1.Otchestvo);
            Console.ReadKey();
            
        }
    }
}
