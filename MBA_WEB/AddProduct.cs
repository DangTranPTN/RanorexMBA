/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/24/2021
 * Time: 11:47 AM
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

namespace MBA_WEB
{
    /// <summary>
    /// Description of AddProduct.
    /// </summary>
    [TestModule("9772AF77-7DDD-4627-ABE7-7D470C778E3A", ModuleType.UserCode, 1)]
    public class AddProduct : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddProduct()
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
            AddNewProduct("$8 DangTran Addproduct for testing", "DangTran Test MetaTag data", "AU_161121", "2021-11-23", "2022-11-16",1);
        }
        public void AddNewProduct(string ProductName, string ProductMetaTag, string productModel, string startDate, string endDate, int storeValue) {
        	var repo = MBA_WEBRepository.Instance;
        	Menu menu = new Menu();
        	menu.ClickMenuItem("Catalog", "Products");
        	Delay.Seconds(3);
        	Report.Log(ReportLevel.Info, "Mouse", "Click Addnew button to add new product with item 'MBA.Navigation.CatalogItem.AddNew' at Center.", repo.MBA.Navigation.CatalogItem.Products.hrefAddNewInfo , new RecordItemIndex(0));
        	repo.MBA.Navigation.CatalogItem.Products.hrefAddNew.Click();
        	menu.setDataAddProduct(ProductName, ProductMetaTag, productModel, startDate, endDate, storeValue);
        	
        }
    }
}
