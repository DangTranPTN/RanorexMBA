/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/17/2021
 * Time: 8:51 AM
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

namespace MBA_Add_Product
{
    /// <summary>
    /// Description of LoginSuccess.
    /// </summary>
    [TestModule("0B60331A-8DC8-473A-8360-8BC7D3E3D96D", ModuleType.UserCode, 1)]
    public class LoginSuccess : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoginSuccess()
        {
            // Do not delete - a parameterless constructor is required!
            CommonAction.repo.MBA.LoginPage.InputNameInfo.WaitForExists(2000);
            CommonAction.repo.MBA.LoginPage.InputName.PressKeys("auto");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Input Password '●●●●●●●●' with focus on 'MBA.LoginPage.InputPassword'.", CommonAction.repo.MBA.LoginPage.InputPasswordInfo, new RecordItemIndex(0));
            CommonAction.repo.MBA.LoginPage.InputPassword.PressKeys("Abcd@123");
            Delay.Milliseconds(0);
            CommonAction.Click(CommonAction.repo.MBA.LoginPage.ClickSubmitButton.GetPath().ToString());
            Delay.Milliseconds(0);
            CommonAction.repo.MBA.LoginPage.ClickSubmitButtonInfo.WaitForNotExists(5000);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title='Auto') on item 'MBA.Profile.Avatar'.", CommonAction.repo.MBA.Profile.AvatarInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(CommonAction.repo.MBA.Profile.AvatarInfo, "Title", "auto");
            Delay.Milliseconds(0);
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
