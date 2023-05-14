
using MyLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS_AZ.Functions.FunctionsOfPersons.FunctionsOfJobSeeker
{
    internal static class FunctionsOfJobSeeker
    {
        //  Class for Main functions of Job Seeker
        class MainFunctionsOfJobSeeker
        {
            //  Show All Vacancies
            public static void ShowAllVacancies() { }

            //  Apply to admin for make premium CV
            public static void ApplyAdminForMakePremiumCV() { }

        }
        public static void MainForJobSeeker()
        {
            //  Options of Jobseeker Menu
            List<string> OptionsOfJobSeekerMenu = new List<string>() { "Show All Vacancies", "Apply to admin for make premium CV", "Exit" };

            //  Jobseeker Menu
            try
            {
                do
                {
                    int SelectedOptionOfMainMenu = MyMenu.CreateMenu("Please select option from Main Menu:", OptionsOfJobSeekerMenu);
                    switch (SelectedOptionOfMainMenu)
                    {
                        //  Show All Vacancies
                        case 0:
                            MainFunctionsOfJobSeeker.ShowAllVacancies();
                            break;

                        //  Apply to admin for make premium CV
                        case 1:
                            MainFunctionsOfJobSeeker.ApplyAdminForMakePremiumCV();
                            break;

                        //  Exit
                        case 2:
                            throw new MyError("You logget out from Job Seeker Menu");
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
