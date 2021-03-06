/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/23/2021
 * Time: 2:44 PM
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
    /// Description of OpenBrowser.
    /// </summary>
    [TestModule("DD96EEFD-AAE4-40F9-B48B-FE7ECBA05624", ModuleType.UserCode, 1)]
    public class OpenBrowser : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser()
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
            OpenBrowserMBA();
        }
        public void OpenBrowserMBA() {
        	Host.Local.KillBrowser("chorme");
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://ptn-test1.oc.mbasrv.com/sbe' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("https://ptn-test1.oc.mbasrv.com/sbe", "Chrome", "--incognito --disable-save-password-bubble --disable-infobars", killExisting:true, maximized:true);
            Delay.Milliseconds(5000);
        }
    }
}
