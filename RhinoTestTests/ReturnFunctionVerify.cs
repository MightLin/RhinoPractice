using Microsoft.VisualStudio.TestTools.UnitTesting;
using RhinoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;

namespace RhinoTest.Tests
{
	[TestClass()]
	public class ReturnFunctionVerify
	{
		private const string input = "abc";

		[TestMethod()]
		public void return_驗證調用次數_VerifyAllExpectations()
		{
			//arrange
			var inject = MockRepository.GenerateMock<IInject>();
			inject.Expect(s => s.ToUpper(Arg<string>.Is.Equal(input))).Return(input.ToUpper()).Repeat.Times(1);

			var test = new TestClass(inject);

			//action
			var actual = test.ToUpper(input);

			//assert
			Assert.AreEqual(input.ToUpper(), actual);
			inject.VerifyAllExpectations();
		}

	}
}