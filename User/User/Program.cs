using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать класс User, описывающий человека (Фамилия, Имя, Отчество, Дата рождения, Возраст). 
//Написать программу, демонстрирующую использование этого класса.

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите все что знаете о себе, немедленно");
            Console.WriteLine("Введите имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string Patronymic = Console.ReadLine();
            Console.WriteLine("Введите день Рождения");
            int Day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения ");
            int Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год рождения ");
            int Year = int.Parse(Console.ReadLine());
            User usr = new User(Name, Surname, Patronymic, Day, Month, Year);
            Console.WriteLine($"все твои данные у нас {usr.Name} {usr.Surname} {usr.Patronymic} твой возраст {usr.Age}");

        }
    }
    class User
    {

        private int day;
        private int month;
        private int year;


        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }
        public int Day
        {
            get => day; private set
            {
                day = value;
                if (day < 1)
                {
                    day = 1;
                }
                if (day > 31)
                {
                    day = 31;
                }
            }
        }
        public int Month
        {
            get => month; private set
            {
                month = value;
                if (month < 1)
                {
                    month = 1;
                }
                if (month > 12)
                {
                    month = 12;
                }
            }
        }
        public int Year
        {
            get => year; private set
            {
                year = value;
                if (year < 1920)
                {
                    year = 1920;
                }
                if (year > 2017)
                {
                    year = 2017;
                }

            }
        }
        public int Age { get; private set; }

        public User(string name, string surname, string patronymic, int day, int month, int year)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Day = day;
            Month = month;
            Year = year;
            var now = DateTime.Now;
            Age = now.Year - Year;
            if (Month > now.Month)
            {
                Age -= 1;

            }
        }





    }


}





