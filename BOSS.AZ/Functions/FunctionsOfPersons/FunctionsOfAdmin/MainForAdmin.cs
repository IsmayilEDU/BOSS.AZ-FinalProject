using MyLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS_AZ.Functions.FunctionsOfPersons.FunctionsOfAdmin
{
    internal static partial class FunctionsOfAdmin
    {

        //  Main fuction of Admin
        public static void MainForAdmin()
        {
            //  Options of Admin Menu
            List<string> OptionsOfAdminMenu = new List<string>()
            {
                "Make the CV premium (by ID)",
                "Make the vacancy premium (by ID)",
                "Remove vacancy (by ID)",
                "İncrease the time of the vacancy (by ID)",
                "Approve the newly created vacancy",
                "Exit"
            };

            //  Admin Menu
            try
            {
                do
                {
                    int SelectedOptionOfMainMenu = MyMenu.CreateMenu("Please select option from Main Menu:", OptionsOfAdminMenu);
                    switch (SelectedOptionOfMainMenu)
                    {
                        //  Make the CV premium (by ID)
                        case 0:
                            FunctionsOfAdmin.MakeCVPremiumByID();
                            break;

                        //  Make the vacancy premium (by ID)
                        case 1:
                            FunctionsOfAdmin.MakeVacancyPremiumByID();
                            break;

                        //  Remove vacancy (by ID)
                        case 2:
                            FunctionsOfAdmin.RemoveVacancyByID();
                            break;

                        //  İncrease the time of the vacancy (by ID)
                        case 3:
                            FunctionsOfAdmin.İncreaseMonthOfVacancyByID();
                            break;

                        //  Approve the newly created vacancy
                        case 4:
                            FunctionsOfAdmin.ApproveNewlyCreatedVacancy();
                            break;

                        //  Exit
                        case 5:
                            throw new MyError("You logget out from Admin Menu");
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
