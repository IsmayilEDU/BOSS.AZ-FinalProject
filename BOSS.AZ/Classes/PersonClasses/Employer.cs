using BOSS_AZ.Classes.PersonClasses.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;
using BOSS_AZ.Classes.VacancyClasses;

namespace BOSS_AZ.Classes.PersonClasses
{
    internal class Employer : User
    {
        public List<Vacancy> Vacancies { get; set; }

        public Employer(string name, string surname, int age, string city, string phone, List<Vacancy> vacancies) : base( name, surname, age, city, phone)
        {
            Vacancies = vacancies;
        }
    }
}
