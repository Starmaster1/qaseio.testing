using BussinesObjects.UI.Pages;
using Core;
using Core.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects.UI.Steps
{
    public class UISteps
    {
        public static void Login(UserModel user)
        {
            new LoginPage()
                .OpenPage()
                .Login(user);
        }
    }
}
