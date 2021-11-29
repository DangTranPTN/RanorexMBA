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
    /// Description of Logout.
    /// </summary>
    [TestModule("60A0B782-9B55-46E9-A95E-C8165E3FE6FC", ModuleType.UserCode, 1)]
    public class Logout : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Logout()
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
            LogoutMBA();
        }
        public void LogoutMBA() {
        	var repo = MBA_WEBRepository.Instance;
        	Report.Log(ReportLevel.Info, "Mouse", "Loging out the system !", MBA_WEBRepository.Instance.MBA.LogoutPage.spanLogoutInfo, new RecordItemIndex(0));
        	if (repo.MBA.LogoutPage.spanLogoutInfo.Exists(3000)) {
        		repo.MBA.LogoutPage.spanLogout.Click();
        	}
        	else {
        		
        		Report.Log(ReportLevel.Info, "There are some problems !");
        	}
            Report.Log(ReportLevel.Info, "Verified Logout !Logout Success !");
        }
    }
}
