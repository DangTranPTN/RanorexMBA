/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/16/2021
 * Time: 10:24 PM
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
    /// Description of CommonAction.
    /// </summary>
    [TestModule("9E15139C-4DD3-4CE0-80DE-DAE7017B6771", ModuleType.UserCode, 1)]
    public class CommonAction : ITestModule
    {
    	public static MBA_Add_ProductRepository repo = MBA_Add_ProductRepository.Instance;
    	public static void Click(string xPath){
    		ButtonTag btnClick = Host.Current.Find<ButtonTag>(xPath)[0];
    		btnClick.Click();
    	}
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
