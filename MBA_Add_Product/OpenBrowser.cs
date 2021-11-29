/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/16/2021
 * Time: 4:06 PM
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
    /// Description of OpenBrowser.
    /// </summary>
    [TestModule("63C7C80B-7499-4AF0-ADB5-20178D9AA102", ModuleType.UserCode, 1)]
    public class OpenBrowser : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser()
        {
            // Do not delete - a parameterless constructor is required!
            Host.Local.KillBrowser("chorme");
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://ptn-test1.oc.mbasrv.com/sbe' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("https://ptn-test1.oc.mbasrv.com/sbe", "Chrome", "--incognito --disable-save-password-bubble --disable-infobars", killExisting:true, maximized:true);
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
