using System;

namespace Registr.Model
{
   public  class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BordDate { get; set; }
        public decimal Salary { get; set; }

        public User()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            BordDate = default;
            Salary = decimal.MinValue;

        }
        public User(int id, string firstName, string middleName, string lastName,
            DateTime bordDate, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BordDate = bordDate;
            Salary = salary;
        }

        public override string ToString() => $"ФИО:{FirstName}{MiddleName}{LastName}\n" +
            $"Дата рождения:{BordDate}\n" + 
            $"Зарплата:{Salary}";

        public string Format() => $"\n{FirstName};{MiddleName};{LastName};{BordDate};{Salary}";
    }
}
