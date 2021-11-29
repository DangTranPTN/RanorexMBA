/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/23/2021
 * Time: 3:53 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using Ranorex;

namespace MBA_WEB.CommonFunctions
{
	/// <summary>
	/// Description of CheckOpenMenu.
	/// </summary>
	public class Menu
	{
		public Menu()
		{
		}
		public static bool CheckOpenMenu(string menuItem) {
			var repo = MBA_WEBRepository.Instance;
			repo.Menu_items = menuItem;
			return repo.MBA.Navigation.ulMenuDropListInfo.Exists(2000);
		}
		public void ClickMenuItem (string parentMenu, string childMenu ) {
			var repo = MBA_WEBRepository.Instance;
        	repo.Menu_items = parentMenu;
        	repo.Item = childMenu;
        	Ranorex.ATag btnParent = repo.MBA.Navigation.hrefParentMenu;
        	Ranorex.ATag btnChild = repo.MBA.Navigation.ChildItem.hrefChildMenu;
        	if (CheckOpenMenu(parentMenu)) {
        		
        		Report.Log(ReportLevel.Info, "Mouse", "Click "+ childMenu +" in " + parentMenu + " to show list with item 'MBA.Navigation.ChildItem.item' at Center.", repo.MBA.Navigation.ChildItem.hrefChildMenuInfo,new RecordItemIndex(0));
        		btnChild.Click();
        		Delay.Seconds(3);
        	}
        	else {
        		Report.Log(ReportLevel.Info, "Mouse", "Click "+ parentMenu +" to show list with item 'MBA.Navigation.itemMenu' at Center.", repo.MBA.Navigation.hrefParentMenuInfo, new RecordItemIndex(1));
        		btnParent.Click();
        		Report.Log(ReportLevel.Info, "Mouse", "Click "+ childMenu +" in "+ parentMenu +" to show list with item 'MBA.Navigation.ChildItem.item' at Center.", repo.MBA.Navigation.ChildItem.hrefChildMenuInfo, new RecordItemIndex(2));
        		btnChild.Click();
        	}
		}
		public void SearchProduct(string productName) {
			var repo = MBA_WEBRepository.Instance;
			Report.Log(ReportLevel.Info, "Set value", "Setting attribute" +productName + "  on item 'MBA.ProductFilter.ProductName'.", repo.MBA.Navigation.CatalogItem.Products.ProductFilter.inputProductNameInfo, new RecordItemIndex(0));
            repo.MBA.Navigation.CatalogItem.Products.ProductFilter.inputProductName.Element.SetAttributeValue("Value", productName);
            Report.Log(ReportLevel.Info, "Mouse", "Click Filter button to find product with item 'MBA.ProductFilter.BtnFilter' at Center.", repo.MBA.Navigation.CatalogItem.Products.ProductFilter.BtnFilterInfo, new RecordItemIndex(1));
            repo.MBA.Navigation.CatalogItem.Products.ProductFilter.BtnFilter.Click();
            Delay.Milliseconds(3000);
            List<string> GetProductFound = GetAllProduct();
			Validate.AreEqual(true, ValidateProductFound(GetProductFound, productName));
		}
		public List<string> GetAllProduct()
        {
			var repo = MBA_WEBRepository.Instance;
			List<string> results = new List<string>();
			results.AddRange(GetProductOnePage());
            while (repo.MBA.Navigation.CatalogItem.Products.ProductList.hrefNextPageInfo.Exists(2000))
            {
            	repo.MBA.Navigation.CatalogItem.Products.ProductList.hrefNextPage.PerformClick();
				results.AddRange(GetProductOnePage());
            }
			return results;
		}
		public List<string> GetProductOnePage()
        {
			var repo = MBA_WEBRepository.Instance;
			var productTable = repo.MBA.Navigation.CatalogItem.Products.ProductList.tbodyProductTable;
			
			List<string> results = new List<string>();
			IList<Ranorex.TrTag> rows = productTable.FindChildren<Ranorex.TrTag>();
			foreach (var row in rows)
			{
				results.Add(row.FindChildren<Ranorex.TdTag>()[2].InnerText);
			}
			return results;
        }
		public bool ValidateProductFound(List<string> GetProductFound, string prodname)
        {
			int countFaild = 0;
			foreach (var res in GetProductFound)
            {
				if (!res.ToLower().Contains(prodname.ToLower())) {
					Report.Log(ReportLevel.Error, string.Format("InValid productname {0}", res.ToString()));
					countFaild++;
                }
				else
                {
					Report.Log(ReportLevel.Info, string.Format("Valid productname {0}", res.ToString()));
                }
            }
			return countFaild > 0 ? false:true;
        }
		public void setDataAddProduct(string ProductName, string ProductMetaTag, string productModel, string startDate, string endDate, int storeValue) {
			//Declare
			var repo = MBA_WEBRepository.Instance;
			var Products = repo.MBA.Navigation.CatalogItem.Products;
			//General Tab
			var aGeneralTab = Products.AddProduct.GeneralTab.hrefGeneralTab;
			var inputProductName = Products.AddProduct.GeneralTab.inputProductName;
			var inputMetaTag = Products.AddProduct.GeneralTab.inputMetaTag;
			
			//Data Tab
			var aDataTab = Products.AddProduct.DataTab.hrefDataTab;
			var inputModel = Products.AddProduct.DataTab.inputModel;
			var inputStartDate = Products.AddProduct.DataTab.inputStartDate;
			var inputEndDate = Products.AddProduct.DataTab.inputEndDate;
			
			var btnSave = Products.AddProduct.BtnSubmit;
			
			//set General info
			aGeneralTab.Click();
			inputProductName.Element.SetAttributeValue("Value", ProductName);
			Delay.Seconds(3);
			
			inputMetaTag.Focus();
			inputMetaTag.Element.SetAttributeValue("Value", ProductMetaTag);
			Delay.Seconds(3);
			
			//set Data info
			aDataTab.Click();
			inputModel.Focus();
			inputModel.Element.SetAttributeValue("Value", productModel);
			Delay.Seconds(3);
			
			inputStartDate.Focus();
			inputStartDate.Element.SetAttributeValue("Value", startDate);
			Delay.Seconds(3);
			
			inputEndDate.Focus();
			inputEndDate.Element.SetAttributeValue("Value", endDate);
			Delay.Seconds(1);
			
			//Save
			btnSave.Click();
			Delay.Seconds(2);
		}
	}
}
