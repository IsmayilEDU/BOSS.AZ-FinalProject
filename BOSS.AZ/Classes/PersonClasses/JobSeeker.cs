using BOSS_AZ.Classes.CVClasses;
using BOSS_AZ.Classes.PersonClasses.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;

namespace BOSS_AZ.Classes.PersonClasses
{
    internal class JobSeeker : User
    {

        //  Constrcutor with parametres
        public JobSeeker(string name, string surname, int age, string city, string phone)
            : base( name, surname, age, city, phone) { }


        //  ToString
        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nCity: {City}\nPhone: {Phone}\n\n";
        }
    }
}
