/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/4/2021
 * Time: 12:00 AM
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

namespace MBATest
{
    /// <summary>
    /// Description of openBrowser.
    /// </summary>
    [TestModule("BBFB6FB5-0934-4F31-AA8E-C9D8B4631CF6", ModuleType.UserCode, 1)]
    public class openBrowser : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public openBrowser()
        {
            // Do not delete - a parameterless constructor is required!
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://ptn-test1.oc.mbasrv.com/sbe' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://ptn-test1.oc.mbasrv.com/sbe", "chrome", "", false, false, false, false, false, false, false, true);
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
