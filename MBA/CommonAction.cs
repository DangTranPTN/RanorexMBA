/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/17/2021
 * Time: 1:36 PM
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
    /// Description of CommonAction.
    /// </summary>
    [TestModule("E168A18E-3742-49E8-BE35-3326EFD9279B", ModuleType.UserCode, 1)]
    public class CommonAction : ITestModule
    {
    	public static MBARepository repo = MBARepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CommonAction()
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
        }
    }
}
