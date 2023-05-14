using BOSS_AZ.Classes.PersonClasses;
using MyLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS_AZ.Classes.CVClasses
{
    internal class CV
    {
        //  ID
        public Guid ID { get; init; }

        //  Premium
        public bool Premium { get; set; }

        //  Job Seeker
        public JobSeeker jobSeeker { get; init; }

        //  Profession
        private string _profession;
        public string Profession
        {
            get { return _profession; }
            init 
            {
                //  Check sent profession 
                if (value == null)
                {
                    throw new Exception("Profession can not be empty!");
                }
                else
                {
                    _profession = value;
                }
            }
        }

        //  Exist university diplom
        public bool UniversityDiplom { get; init; }

        //  Languages ( language, level)
        public Dictionary<string, string> Languages { get; set; }

        //  Work experiences
        public List<WorkExperience> WorkExperiences { get; set; }

        //  Constructor with parametres
        public CV(JobSeeker jobSeeker, string profession, bool universityDiplom, Dictionary<string, string> languages, List<WorkExperience> workExperiences)
        {
            ID = Guid.NewGuid();
            Premium = false;
            this.jobSeeker = jobSeeker;
            this.Profession = profession;
            UniversityDiplom = universityDiplom;
            Languages = languages;
            WorkExperiences = workExperiences;
        }

        public override string ToString()
        {
            string str = this.ID.ToString() + "\n";
            str = this.jobSeeker.ToString();
            str += $"Profession: {Profession}\nHas University Diplom {UniversityDiplom}\n\n";
            str += "Languages and levels\n\n";
            foreach (var language in Languages)
            {
                str += $"[{language.Key} : {language.Value}]\n";
            }
            str += "\n";
            str += "Work experiences:\n\n";
            foreach (var workExperience in WorkExperiences)
            {
                str+= workExperience.ToString();
            }
            return str;
        }
    }
}
