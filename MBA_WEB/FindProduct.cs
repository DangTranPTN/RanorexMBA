/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/23/2021
 * Time: 3:49 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;
using MBA_WEB.CommonFunctions;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using System.Linq;

namespace MBA_WEB
{
    /// <summary>
    /// Description of FindProduct.
    /// </summary>
    [TestModule("E40CD34E-C2E3-47A8-8F27-627DBF1260FB", ModuleType.UserCode, 1)]
    public class FindProduct : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FindProduct()
        {
            // Do not delete - a parameterless constructor is required!
        }
        string _prodname = "";
		[TestVariable("fefa5de2-e20b-47a7-8a69-d6f965dd8740")]
		public string prodname
		{
			get { return _prodname; }
			set { _prodname = value; }
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
            CommonFunctions.Menu menu = new CommonFunctions.Menu();
            FindProductCatalog(prodname);
//            menu.ShowMenuItem("Catalog", "Categories");
//            menu.ShowMenuItem("Extensions", "Installer");
        }
        public static void FindProductCatalog(string productName) {
        	var repo = MBA_WEBRepository.Instance;
        	Menu menu = new Menu();
        	menu.ClickMenuItem("Catalog", "Products");
			menu.SearchProduct(productName);
			
        }
        	
    }
}
