using System;

namespace Лб2__5
{
    class User
    {
        private string _login, _name, _surname, _date;
        private int _age;

        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public User()
        {
            DateTime a = DateTime.Now;
            _date = a.ToString("d");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Логін: {_login}");
            Console.WriteLine($"Ім'я: {_name}");
            Console.WriteLine($"Прізвище: {_surname}");
            Console.WriteLine($"Вік: {_age}");
            Console.WriteLine($"Дата заповнення анкети: {_date}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            User firstUser = new User();

            firstUser.login = "denzaydunden@gmail.com";
            firstUser.name = "Денис";
            firstUser.surname = "Зайдун";
            firstUser.age = 18;

            firstUser.GetInfo();

            Console.ReadKey();
        }
    }
}
