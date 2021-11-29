/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/4/2021
 * Time: 12:55 AM
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
    /// Description of inputText.
    /// </summary>
    [TestModule("07F64EAB-D687-4E1C-8F91-15162A07BF42", ModuleType.UserCode, 1)]
    public class inputText : ITestModule
    {
    	public static MBATestRepository repo = MBATestRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public inputText()
        {
            // Do not delete - a parameterless constructor is required!
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'auto' with focus on 'MBATest.Login.InputUsername'.", repo.MBATest.Login.InputUsernameInfo, new RecordItemIndex(0));
            repo.MBATest.Login.InputUsername.PressKeys("auto");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '********' with focus on 'MBATest.Login.InputPassword'.", repo.MBATest.Login.InputPasswordInfo, new RecordItemIndex(1));
            repo.MBATest.Login.InputPassword.PressKeys("Abcd@123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MBATest.Login.BtnSubmit' at 37;19.", repo.MBATest.Login.BtnSubmitInfo, new RecordItemIndex(5));
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
