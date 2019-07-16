using System;

namespace _2._3_user
{
    class User
    {
        public string name;
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
        private string surname;
        public string Surname // фамилия 
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
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
            Console.WriteLine(surname);
            Console.WriteLine(Name);
            Console.WriteLine(Patronymic);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.Write("Введите имя : ");
            user.Name = Console.ReadLine();
            Console.Write("Введите фамилию : ");
            user.Surname = Console.ReadLine();
            Console.Write("Введите Отчество : ");
            user.Patronymic = Console.ReadLine();

            Console.WriteLine("Введите год рождения");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день рождения");
            int day = int.Parse(Console.ReadLine());

            user.Birthday = new DateTime(year, month, day);

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd")); // Cупер вычисление возвраста )) рабочее!!)
            int dob = int.Parse(user.Birthday.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            user.Show();

            Console.WriteLine(user.Birthday.ToString("d"));
            Console.WriteLine("Возвраст = " + age );
            Console.ReadKey();
        }
    }
}