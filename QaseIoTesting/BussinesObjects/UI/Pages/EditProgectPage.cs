using BussinesObjects.API.RestEntities;
using Core;
using Core.Selenium.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects.UI.Pages
{
    public class EditProgectPage : BasePage
    {
        private Input projectNameInput = new("project-name");
        private Input projectCodeInput = new("project-code");
        private TextArea descriptionTextArea = new("description-area");
        private Button updateButton = new("submit");
        private RadioButton privateRadioButton = new("public");
        private RadioButton publicRadioButton = new("private");
        public EditProgectPage GeneralSettingsProject(ProjectModel project, string access)
        {
            logger.Info($"[GUI] Редактируем основные настройки проекта. Меняем название на '{project.Title}', Код: '{project.Code}', Описание: '{project.Description}'");
            projectNameInput.GetElement().Clear();
            projectNameInput.GetElement().SendKeys(project.Title);
            projectCodeInput.GetElement().Clear();
            projectCodeInput.GetElement().SendKeys(project.Code);
            descriptionTextArea.GetElement().Clear();
            descriptionTextArea.GetElement().SendKeys(project.Description);
            switch (access)
            {
                case "public":
                    publicRadioButton.GetElement().Click();
                    break;
                case "private":
                    privateRadioButton.GetElement().Click();
                    break;
                default:
                    privateRadioButton.GetElement().Click();
                    break;
            }
            updateButton.GetElement().Click();
            return this;
        }
    }
}
