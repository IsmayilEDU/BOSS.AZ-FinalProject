using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;

namespace BOSS_AZ.Classes.CVClasses
{
    internal class WorkExperience
    {
        //  Company
        private string _company;
        public string Company
        {
            get { return _company; }
            init 
            {
                if (value == null)
                {
                    throw new Exception("Company never can be empty!");
                }
                else
                {
                    _company = value;
                }
            }
        }

        //  Position
        private string _position;
        public string Position
        {
            get { return _position; }
            init
            {
                if (value == null)
                {
                    throw new Exception("Company never can be empty!");
                }
                else
                {
                    _position = value;
                }
            }
        }

        //  Date that start work
        public DateTime StartDate { get; init; }

        //  Date that finish work
        private DateTime _FinishDate;
        public DateTime FinishDate
        {
            get { return _FinishDate; }
            init 
            {
                //  Check finish date
                if (value > StartDate)
                {
                    _FinishDate = value;
                }
            }
        }

        //  Constructor with parametres
        public WorkExperience(string company, string position, DateTime startDate, DateTime finishDate)
        {
            Company = company;
            Position = position;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        //  ToString
        public override string ToString()
        {
            return $"Work EXperience info\nCompany: {Company}\nPosition: {Position}\nStart date: {StartDate.ToShortDateString()}\nFinish date: {FinishDate.ToShortDateString()}\n";
        }

    }
}
