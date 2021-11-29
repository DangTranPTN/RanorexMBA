/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/3/2021
 * Time: 8:40 PM
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
    /// Description of WriteUsername.
    /// </summary>
    [TestModule("7E47200A-9AD4-4015-A840-A62DFE866A63", ModuleType.UserCode, 1)]
    public class WriteUsername : ITestModule
    {
    	/// <summary>
        /// Holds an instance of the Project1Repository repository.
        /// </summary>
        public static Project1Repository repo = Project1Repository.Instance;

        public WriteUsername()
        {
            // Do not delete - a parameterless constructor is required!
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'auto' with focus on 'MBATest.Login.InputUsername'.", repo.MBATest.Login.InputUsernameInfo, new RecordItemIndex(0));
            repo.MBATest.Login.InputUsername.PressKeys("auto");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '********' with focus on 'MBATest.Login.InputPassword'.", repo.MBATest.Login.InputPasswordInfo, new RecordItemIndex(1));
            repo.MBATest.Login.InputPassword.PressKeys("Abcd@123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse center Click item 'MBATest.Login.BtnSubmit' at 37;19.", repo.MBATest.Login.BtnSubmitInfo, new RecordItemIndex(2));
            repo.MBATest.Login.BtnSubmit.Click("37;19");
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
