/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/3/2021
 * Time: 8:58 PM
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

namespace Project1
{
    /// <summary>
    /// Description of closeBrowser.
    /// </summary>
    [TestModule("1A84AFFC-E186-44E9-90E3-08855EC21C18", ModuleType.UserCode, 1)]
    public class closeBrowser : ITestModule
    {
    	/// <summary>
        /// Holds an instance of the Project1Repository repository.
        /// </summary>
        public static Project1Repository repo = Project1Repository.Instance;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public closeBrowser()
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
            
            Report.Log(ReportLevel.Info, "Website", "Closing application containing item 'MBA testing web'.", repo.MBATest.SelfInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.MBATest.Self, new Duration(0));
            Delay.Milliseconds(0);
        }
    }
}
