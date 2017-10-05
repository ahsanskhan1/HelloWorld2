using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AKProducts.Controllers;
using System.Web.Mvc;

namespace APIProduct.Tests
{
	[TestClass]
	public class HelloWorldControllerTest
	{
		[TestMethod]
		public void HelloWorld_Get()
		{
			// Arrange
			HelloWorldController controller = new HelloWorldController();

			// Act
			ViewResult result = controller.Get() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual("Hello World From API", result.ViewBag.Title);

		}
	}
}
