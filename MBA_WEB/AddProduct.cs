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
        
        string _productName = "";
        [TestVariable("dc5c661e-1bcb-455f-ac1b-5f03df420d90")]
        public string productName
        {
        	get { return _productName; }
        	set { _productName = value; }
        }
        
        string _productMetaTag = "";
        [TestVariable("cc176c7f-68d8-411b-8d90-77536d9d65ab")]
        public string productMetaTag
        {
        	get { return _productMetaTag; }
        	set { _productMetaTag = value; }
        }
        
        string _productModel = "";
        [TestVariable("6f64f36b-40d3-493d-97e5-a3a37d5fc6d7")]
        public string productModel
        {
        	get { return _productModel; }
        	set { _productModel = value; }
        }
        
        string _startDate = "";
        [TestVariable("9ccb45fa-7589-41df-9ae3-f1d033a7bd29")]
        public string startDate
        {
        	get { return _startDate; }
        	set { _startDate = value; }
        }
        
        string _endDate = "";
        [TestVariable("37b3aadf-2784-44db-a199-4f218d456bba")]
        public string endDate
        {
        	get { return _endDate; }
        	set { _endDate = value; }
        }
        
        string _storeValue = "";
        [TestVariable("4b74332f-8afc-4d87-95a9-4fa32ceb5865")]
        public string storeValue
        {
        	get { return _storeValue; }
        	set { _storeValue = value; }
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
            AddNewProduct(productName, productMetaTag, productModel, startDate, endDate, storeValue);
        }
        public void AddNewProduct(string ProductName, string ProductMetaTag, string productModel, string startDate, string endDate, string storeValue) {
        	var repo = MBA_WEBRepository.Instance;
        	Menu menu = new Menu();
        	menu.ClickMenuItem("Catalog", "Products");
        	Delay.Seconds(3);
        	Report.Log(ReportLevel.Info, "Mouse", "Click Addnew button to add new product with item 'MBA.Navigation.CatalogItem.AddNew' at Center.", repo.MBA.Navigation.CatalogItem.Products.hrefAddNewInfo , new RecordItemIndex(0));
        	repo.MBA.Navigation.CatalogItem.Products.hrefAddNew.Click();
        	menu.setDataAddProduct(ProductName, ProductMetaTag, productModel, startDate, endDate, storeValue);
            FindProduct.FindProductCatalog(ProductName);
        }
    }
}
