using BOSS_AZ.Classes.PersonClasses.AbstractClasses;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;

namespace BOSS_AZ.Classes.PersonClasses
{
    internal class Admin : Person
    {
		//	Login
		private string _login;
		public string Login
		{
			get { return _login; }
			set 
			{
				//	Check other symbol in login
				if (MyString.CheckOnlyLettersInString(value))
				{
                    _login = value;
				}

				//	If the condition is not met
				else
				{
					throw new Exception("Login can contain only letters!");
				}
			}
		}

		//	Password
		private string _password;
        public string Password
		{
			get { return _password; }
			set
			{
                //	Check other symbol in password
                if (MyString.CheckOnlyLettersInString(value))
                {
                    _password = value;
                }

                //	If the condition is not met
                else
                {
                    throw new Exception("Password can contain only letters!");
                }
            }
		}

		//	Constructor with parametres
        public Admin( string name, string surname, string login, string password) : base( name, surname)
        {
			Login = login;
			Password = password;
        }

		//	ToString
		public override string ToString()
		{
			return base.ToString() + $"Login: {Login}\nPassword: {Password}\n";
		}

	}
}
