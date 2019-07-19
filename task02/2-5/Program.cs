using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2_5
{
    class User
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname // фамилия 
        { get; set; }
        private string patronymic; //отчество
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
            }
        }
        public DateTime Birthday;

        public void Show()
        {
            Console.WriteLine(Surname);
            Console.WriteLine(Name);
            Console.WriteLine(Patronymic);

        }

    }
    class Employee : User
    {
        private string position;
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        private string experience;
        public string Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Введите имя : ");
            employee.Name = Console.ReadLine();
            Console.Write("Введите фамилию : ");
            employee.Surname = Console.ReadLine();
            Console.Write("Введите Отчество : ");
            employee.Patronymic = Console.ReadLine();
            Console.Write("Введите стаж : ");
            employee.Experience = Console.ReadLine();
            Console.Write("Введите должность : ");
            employee.Position = Console.ReadLine();
            Console.WriteLine("Введите год рождения");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день рождения");
            int day = int.Parse(Console.ReadLine());

            employee.Birthday = new DateTime(year, month, day);

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd")); // Cупер вычисление возвраста )) 
            int dob = int.Parse(employee.Birthday.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            employee.Show();

            Console.WriteLine(employee.Experience);
            Console.WriteLine(employee.Position);

            Console.WriteLine(employee.Birthday.ToString("d"));

            Console.WriteLine("Возвраст = " + age);
            Console.ReadKey();
        }
    }
}