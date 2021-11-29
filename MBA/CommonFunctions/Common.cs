/*
 * Created by Ranorex
 * User: DangTranPTN
 * Date: 11/17/2021
 * Time: 3:39 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;

namespace MBA.CommonFunctions
{
	/// <summary>
	/// Description of Common.
	/// </summary>
	public class Common
	{
		public static MBARepository repo = MBARepository.Instance;
		public Common()
		{
		}
		public static void Click(string xPath){
    		ButtonTag btnClick = Host.Current.Find<ButtonTag>(xPath)[0];
    		btnClick.Click();
    	}
	}
}
