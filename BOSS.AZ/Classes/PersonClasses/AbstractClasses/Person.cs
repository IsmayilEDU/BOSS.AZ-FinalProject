using MyLibrary;
using MyLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS_AZ.Classes.PersonClasses.AbstractClasses
{
    //  Abstract Class
    internal abstract class Person
    {
        //  ID
        public Guid ID { get; init; }

        //  Name
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                //  Check other symbol in name
                if (MyString.CheckOnlyLettersInString(value))
                {
                    _name = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Name can only contain letters!");
                }
            }
        }

        //  Surname
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                //  Check other symbol in surname
                if (MyString.CheckOnlyLettersInString(value))
                {
                    _surname = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Surname can only contain letters!");
                }
            }
        }

        //  Fullname
        public string Fullname { get; }

        protected Person(string name, string surname)
        {
            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Fullname = name + " " + surname;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSurname: {Surname}\n";
        }

    }
}
