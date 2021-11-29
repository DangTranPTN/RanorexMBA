/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/23/2021
 * Time: 2:50 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MBA_WEB
{
    /// <summary>
    /// Description of Login.
    /// </summary>
    [TestModule("64072738-CBF0-4127-A41A-2DF48DF92236", ModuleType.UserCode, 1)]
    public class Login : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            LoginMBA("auto","Abcd@123");
        }
        private void LoginMBA(string username, string password) {
        	            MBA_WEBRepository repo = MBA_WEBRepository.Instance;
            // Do not delete - a parameterless constructor is required!
            repo.MBA.LoginPage.InputNameInfo.WaitForExists(3000);
            Report.Log(ReportLevel.Info, "Set value", "Input Username 'auto' with focus on 'MBA.LoginPage.InputName'.", repo.MBA.LoginPage.InputNameInfo, new RecordItemIndex(1));
            repo.MBA.LoginPage.InputName.Element.SetAttributeValue("Value", username);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Set value", "Input Password '●●●●●●●●' with focus on 'MBA.LoginPage.InputPassword'.", repo.MBA.LoginPage.InputPasswordInfo, new RecordItemIndex(2));
            repo.MBA.LoginPage.InputPassword.Element.SetAttributeValue("Value",password);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Click Submit to login with item 'MBA.LoginPage.ClickSubmitButton' at Center.", repo.MBA.LoginPage.ClickSubmitButtonInfo, new RecordItemIndex(3));
            Ranorex.Button btnSubmit = repo.MBA.LoginPage.ClickSubmitButton;
            btnSubmit.Click();
            Delay.Milliseconds(300);
            
            repo.MBA.LoginPage.ClickSubmitButtonInfo.WaitForNotExists(5000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title='auto') on item 'MBA.Profile.Avatar'.", repo.MBA.Profile.AvatarInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MBA.Profile.AvatarInfo, "Title", "auto");
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Verified username !Login Success !");
        }
    }
}
