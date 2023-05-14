using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;
using BOSS_AZ.Classes.PersonClasses;

namespace BOSS_AZ.Classes.VacancyClasses
{
    internal class Vacancy
    {
        //  ID
        public Guid ID { get; init; }

        //  Employer ID
        public Guid EmployerID { get; init; }

        //  Category
        private string _Category;
        public string Category
        {
            get { return _Category; }
            set 
            {
                //  Check sent category
                if (value == null)
                {
                    throw new Exception("Category can not be empty");
                }
                else
                {
                    _Category = value;
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

                //  If the condition is not met
                else
                {
                    throw new Exception("City can contain only letters!");
                }
            }
        }

        //  RequiredWorkExperience
        private int _RequiredWorkExperience;
        public int RequiredWorkExperience
        {
            get { return _RequiredWorkExperience; }
            init 
            {
                //  RequiredWorkExperience should be more than 0
                if (value > 0)
                {
                    _RequiredWorkExperience = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("RequiredWorkExperience should be more than 0!");
                }
            }
        }

        //  Premium
        public bool Premium { get; set; }

        //  End time of vacancy
        private DateTime _FinishDate;
        public DateTime FinishDate
        {
            get { return _FinishDate; }
            set 
            {
                _FinishDate = value.AddMonths(1);
            }
        }


        //  Constructor with paramtres
        public Vacancy(Guid employerID, string category, string city, int requiredWorkExperience)
        {
            ID = Guid.NewGuid();
            EmployerID = employerID;
            Category = category;
            City = city;
            Premium = false;
            RequiredWorkExperience = requiredWorkExperience;
            FinishDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nCategory: {Category}\nCity: {City}\nRequired work experience: {RequiredWorkExperience}\nPremium: {Premium}\nFinish date: {FinishDate.ToShortDateString()}\n\n";
        }

    }
}
