﻿/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/17/2021
 * Time: 1:32 PM
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
    /// Description of CloseBrowser.
    /// </summary>
    [TestModule("7B909031-A203-4BDF-8140-611F2A5576F0", ModuleType.UserCode, 1)]
    public class CloseBrowser : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseBrowser()
        {
            // Do not delete - a parameterless constructor is required!
            Report.Log(ReportLevel.Info, "Website", "Closing application containing item 'MBA testing web'.", MBARepository.Instance.MBA.LoginPage.SelfInfo, new RecordItemIndex(0));
            Host.Local.KillBrowser("chrome");
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
