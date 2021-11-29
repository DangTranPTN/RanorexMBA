/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/16/2021
 * Time: 3:59 PM
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
    /// Description of ClickSubmit.
    /// </summary>
    [TestModule("F4FDDB56-8569-4715-8DB7-F7DAA4254842", ModuleType.UserCode, 1)]
    public class ClickSubmit : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickSubmit()
        {
            // Do not delete - a parameterless constructor is required!
//            CommonAction.Click(CommonAction.repo.MBA.LoginPage.ClickSubmitButton.GetPath().ToString());
            
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
