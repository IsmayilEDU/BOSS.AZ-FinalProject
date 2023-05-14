using MyLibrary;
using MyLibrary.Classes;
using BOSS_AZ.Functions;
using System.Net.Mail;
using System.Net;
using BOSS_AZ.Classes.PersonClasses;
using BOSS_AZ.Classes.CVClasses;
using BOSS_AZ.Functions.FunctionsOfPersons.FunctionsOfAdmin;
using BOSS_AZ.Functions.FunctionsOfPersons.FunctionsOfEmployer;
using BOSS_AZ.Functions.FunctionsOfPersons.FunctionsOfJobSeeker;
using BOSS_AZ.Classes.VacancyClasses;

namespace BOSS_AZ
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            //  Admin of program
            Admin admin = new Admin("Cavid", "Atamoghlanov", "admin", "admin");

            //  Options of Main Menu
            List<string> OptionsOfMainMenu = new List<string>() { "Admin", "Job Seeker", "Employer", "Exit" };

            //  Main Menu
            try
            {
                do
                {
                    int SelectedOptionOfMainMenu = MyMenu.CreateMenu("Please select option from Main Menu:", OptionsOfMainMenu);
                    switch (SelectedOptionOfMainMenu)
                    {
                        //  Admin Menu
                        case 0:
                            FunctionsOfAdmin.MainForAdmin();
                            break;

                        //  Job Seeker Menu
                        case 1:
                            FunctionsOfJobSeeker.MainForJobSeeker();
                            break;

                        //  Employer Menu
                        case 2:
                            FunctionsOfEmployer.MainForEmployer();
                            break;

                        //  Exit
                        case 3:
                            throw new MyError("You logget out from program");
                    }
                } while (true);
            }
            catch (MyError error)
            {
                MyConsole.ShowDescriptionInRed(error.Message);
            }
            */

            List<Employer> list = new List<Employer>();
            {

            }


        }
    }
}