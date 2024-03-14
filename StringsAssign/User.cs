using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssign
{
    public class User
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public string? Surname { get; private set; }
        public string? Email { get; private set; }

        public User(int id , string name , string surname , string emlail)
        {
            Id = id;
            Name = name;
            Surname = surname; 
            Email = emlail;
        }

        public string DisplayUserInfo()
        {
            return $"Id: {Id} " +
                   $"\nName: {Name}" +
                   $"\nSurname: {Surname}" +
                   $"\nEmail: {Email}";
        }

    }
}
