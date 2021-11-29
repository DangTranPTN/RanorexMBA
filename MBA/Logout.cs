/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/17/2021
 * Time: 3:36 PM
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
    /// Description of LogOut.
    /// </summary>
    [TestModule("3489BD23-2A9E-46D6-AD59-1186EFDA1DDD", ModuleType.UserCode, 1)]
    public class Logout : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Logout()
        {
            // Do not delete - a parameterless constructor is required!
            Report.Log(ReportLevel.Info, "Mouse", "Loging out the system !", MBARepository.Instance.MBA.LogoutPage.LogoutInfo, new RecordItemIndex(0));
            Ranorex.SpanTag Logout = MBARepository.Instance.MBA.LogoutPage.Logout;
            Logout.Click();
            MBARepository.Instance.MBA.LoginPage.ClickSubmitButtonInfo.WaitForExists(5000);
            Report.Log(ReportLevel.Info, "Verified Logout !Logout Success !");
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
