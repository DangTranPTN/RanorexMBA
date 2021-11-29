/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/16/2021
 * Time: 5:44 PM
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
    /// Description of ClickButton.
    /// </summary>
    [TestModule("ED35716E-6448-4F07-8455-11C6852F9D3E", ModuleType.UserCode, 1)]
    public class ClickButton : ITestModule
    {
    	public static MBA_Add_ProductRepository repo = MBA_Add_ProductRepository.Instance;
    	public static void Log(string content) {
    		Console.WriteLine("abcdef");
        }
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public  ClickButton()
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
