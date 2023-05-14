using MyLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS_AZ.Functions.FunctionsOfPersons.FunctionsOfEmployer
{
    internal static partial class FunctionsOfEmployer
    {
        
        //  Main fuction of Employer
        public static void MainForEmployer()
        {
            //  Options of Jobseeker Menu
            List<string> OptionsOfEmployerMenu = new List<string>()
            {
                "Apply to Job Seekers",
                "Apply to admin for make premium vacancy",
                "Apply to admin for increase time of vacancy",
                "Exit" };

            //  Jobseeker Menu
            try
            {
                do
                {
                    int SelectedOptionOfMainMenu = MyMenu.CreateMenu("Please select option from Main Menu:", OptionsOfEmployerMenu);
                    switch (SelectedOptionOfMainMenu)
                    {
                        //  Show All Vacancies
                        case 0:
                            FunctionsOfEmployer.ShowAllJobSeekers();
                            break;

                        //  Apply to admin for make premium vacancy
                        case 1:
                            FunctionsOfEmployer.ApplyAdminForMakePremiumVacancy();
                            break;

                        //  Apply to admin for increase time of vacancy
                        case 2:
                            FunctionsOfEmployer.ApplyAdminForMakeIncreaseTimeOfVacancy();
                            break;

                        //  Exit
                        case 3:
                            throw new MyError("You logget out from Employer Menu");
                    }
                } while (true);
            }
            catch (MyError error)
            {
                MyConsole.ShowDescriptionInRed(error.Message);
            }
        }
    }
}
