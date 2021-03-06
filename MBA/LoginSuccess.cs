/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/17/2021
 * Time: 1:35 PM
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

namespace MBA
{
    /// <summary>
    /// Description of LoginSuccess.
    /// </summary>
    [TestModule("5676950D-E91D-4292-AF8D-4B00ACF4718C", ModuleType.UserCode, 1)]
    public class LoginSuccess : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoginSuccess()
        {
        	var repo = CommonFunctions.Common.repo;
            // Do not delete - a parameterless constructor is required!
            Report.Log(ReportLevel.Info, "Keyboard", "Input Username 'auto' with focus on 'MBA.LoginPage.InputName'.", repo.MBA.LoginPage.InputNameInfo, new RecordItemIndex(0));
            repo.MBA.LoginPage.InputNameInfo.WaitForExists(3000);
            repo.MBA.LoginPage.InputName.PressKeys("auto");
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Input Password '●●●●●●●●' with focus on 'MBA.LoginPage.InputPassword'.", repo.MBA.LoginPage.InputPasswordInfo, new RecordItemIndex(1));
            repo.MBA.LoginPage.InputPassword.PressKeys("Abcd@123");
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Click Submit to login with item 'MBA.LoginPage.ClickSubmitButton' at Center.", repo.MBA.LoginPage.ClickSubmitButtonInfo, new RecordItemIndex(2));
            Ranorex.Button btnSubmit = repo.MBA.LoginPage.ClickSubmitButton;
            btnSubmit.Click();
            Delay.Milliseconds(300);
            
            repo.MBA.LoginPage.ClickSubmitButtonInfo.WaitForNotExists(5000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title='auto') on item 'MBA.Profile.Avatar'.", CommonAction.repo.MBA.Profile.AvatarInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MBA.Profile.AvatarInfo, "Title", "auto");
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Verified username !Login Success !");
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
        }
    }
}
