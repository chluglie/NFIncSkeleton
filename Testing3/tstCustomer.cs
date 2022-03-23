using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestingCustomer
{
	[TestClass]
	public class tstCustomer
	{
		[Testmethod]
		public void InstanceOk()
		{
			//create an instance of the class customer
			clsCustomer AnCustomer = new clsCustomer();
			//test if the the class exists
			Assert.IsNotNull(AnCustomer);
		}
	}
}