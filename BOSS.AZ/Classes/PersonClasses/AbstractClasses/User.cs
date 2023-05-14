using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;

namespace BOSS_AZ.Classes.PersonClasses.AbstractClasses
{
    internal abstract class User : Person
    {
        //  Age
        private int _age;
        public int Age
        {
            get { return _age; }
            init 
            {
                //  Age never been less than 18
                if (value >= 18)
                {
                    _age = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Age never been less than 18!");
                }
            }
        }

        //  City
        private string _city;
        public string City
        {
            get { return _city; }
            init 
            {
                //  Check sent city
                if (value != null && MyString.CheckOnlyLettersInString(value))
                {
                    _city = value;
                }

                else
                {
                    throw new Exception("City can not be empty!");
                }
            }
        }

        //  Phone
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            init 
            {
                //  Check other symbol in sent phone
                if (MyString.CheckOnlyNumberInstring(value))
                {
                    //  Length should be 10
                    if (value.Length == 10)
                    {
                        _phone = value;
                    }

                    else
                    {
                        throw new Exception("Length should be 10!");
                    }
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Phone can contain only numbers!");
                }
            }
        }

        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }


        public User( string name, string surname, int age, string city, string phone) : base( name, surname)
        {
            Age = age;
            City = city;
            Phone = phone;
        }
    }
}
